using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LibraryManager3
{
    internal class ControlBooks
    {
        private string path = Application.StartupPath+@"/data/fisier.txt";

        private List<Book> lista;

        public ControlBooks()
        {
            lista=new List<Book>();
            this.load();

        }

        private void load()
        {
            this.lista.Clear();
            StreamReader reader = new StreamReader(path);

            string line = "";

            while ((line=reader.ReadLine())!=null)
            {
                Book book = new Book(line);

                lista.Add(book);
            }

            reader.Close();

        }

        public string afisare()
        {

            string text = "";

            for (int i = 0; i<lista.Count; i++)
            {
                text+=this.lista[i].descricption();
            }
            return text;
        }

        public void delete(string title)
        {

            for (int i = 0; i<lista.Count; i++)
            {
                if (this.lista[i].getTitle().Equals(title))
                {
                    this.lista.RemoveAt(i);
                    i--;
                }
            }

        }

        public void add(Book book)
        {

            this.lista.Add(book);

        }

        public List<Book> getAllBooks()
        {

            return lista;

        }

        public string toSave()
        {

            string text = "";
            int i = 0;

            for (i=0; i<lista.Count-1; i++)
            {
                text+=lista[i].toSave()+"\n";
            }
            text+=lista[i].toSave();

            return text;

        }

        public void save()
        {
            StreamWriter write = new StreamWriter(path);

            write.WriteLine(toSave());

            write.Close();

        }

        public Book returnBookByTitle(string title)
        {

            for (int i = 0; i<lista.Count; i++)
            {
                if (lista[i].getTitle().Equals(title))
                {
                    return lista[i];
                }
            }
            return null;
        }

        public void update(string title, Book newBook)
        {

            Book oldBook = this.returnBookByTitle(title);

            oldBook.setAutohr(newBook.getAuthor());
            oldBook.setGenre(newBook.getGenre());
            oldBook.setYear(newBook.getYear());

        }

    }


}
