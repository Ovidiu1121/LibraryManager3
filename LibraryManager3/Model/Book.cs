using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager3
{
    internal class Book
    {

        private string title;
        private string author;
        private string genre;
        private int year;

        public Book()
        {


        }

        public Book(string title, string author, string genre, int year)
        {

            this.title = title;
            this.author = author;
            this.genre = genre;
            this.year = year;

        }

        public Book(string text)
        {

            string[] part = text.Split(",");

            title = part[0];
            author = part[1];
            genre = part[2];
            year = int.Parse(part[3]);

        }

        public string descricption()
        {

            string text = "";

            text+=this.title+",";
            text+=this.author+",";
            text+=this.genre+",";
            text+=this.year+"\n";

            return text;
        }

        public string getTitle()
        {
            return this.title;

        }

        public void setTitle(string title)
        {
            this.title=title;
        }

        public string getAuthor()
        {
            return this.author;
        }

        public void setAutohr(string author)
        {

            this.author=author;

        }

        public string getGenre()
        {
            return this.genre;
        }

        public void setGenre(string genre)
        {
            this.genre=genre;
        }

        public int getYear()
        {
            return this.year;
        }

        public void setYear(int year)
        {
            this.year=year;
        }

        public string toSave()
        {

            string text = "";

            text+=this.title+",";
            text+=this.author+",";
            text+=this.genre+",";
            text+=this.year;

            return text;
        }

        }
    }
