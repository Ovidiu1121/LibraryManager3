using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager3
{
    internal class PnlAllBooks:Panel
    {
        private ListView lst;
        private FrmHome form;
        private ControlBooks controlBooks=new ControlBooks();

        public PnlAllBooks(FrmHome form)
        {
            this.form = form;
            this.Location = new Point(185, 101);
            this.Size = new Size(615, 349);
            this.Name="PnlAllBooks";
            this.BackColor = Color.Wheat;
            this.Anchor=AnchorStyles.Right|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Top;

            this.lst = new ListView();
            this.Controls.Add(this.lst);
            this.lst.View=View.Details;
            this.lst.GridLines=true;
            this.lst.Location=new Point(70, 47);
            this.lst.Size=new Size(478, 266);
            this.lst.BackColor=Color.AliceBlue;

            populate(this.controlBooks.getAllBooks());

        }
        
        private void populate(List<Book> lista)
        {

            this.lst.Clear();
            this.lst.Columns.Add("Title", 170, HorizontalAlignment.Left);
            this.lst.Columns.Add("Author", 150, HorizontalAlignment.Center);
            this.lst.Columns.Add("Genre", 100, HorizontalAlignment.Left);
            this.lst.Columns.Add("Year", 50, HorizontalAlignment.Left);

            foreach(Book book in lista)
            {

                ListViewItem item = new ListViewItem();

                item.Text=book.getTitle();
                item.SubItems.Add(book.getAuthor().ToString());
                item.SubItems.Add(book.getGenre().ToString());
                item.SubItems.Add(book.getYear().ToString());

                this.lst.Items.Add(item);

            }

        }

    }
}
