using System;

namespace Serie
{
    public class Serie : Base
    {
        public Serie(int id, Genre genre, string title, string description, int year)
        {
            this.id = id;
            this.genre = genre;
            this.title = title;
            this.description = description;
            this.year = year;
        }

        public override string ToString()
        {
            string str = "";

            str += ("Object: " + base.ToString() + "\n");
            str += ("Id: " + this.id + "\n");
            str += ("Genre: " + this.genre + "\n");
            str += ("Title: " + this.title + "\n");
            str += ("Description: " + this.description + "\n");
            str += ("Year: " + this.year + Environment.NewLine);

            return str;
        }

        private Genre genre
        {
            get;
            set;
        }

        private string title
        {
            get;
            set;
        }

        private string description
        {
            get;
            set;
        }

        private int year
        {
            get;
            set;
        }
    }
}