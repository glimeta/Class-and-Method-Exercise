using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_Exercise
{
    class Book
    {
        public string Author { get; set; }
        public string Name   { get; set; }
        public int    Pages  { get; set; }

        public string Print()
        {
            return this.Author + ", " + this.Name + ", " + this.Pages + " pages";
        }


        public Book(string title, string author, int pages)     //constructor to minimize no. of code lines in program 
        {
            Author = author;
            Name =   title;
            Pages =  pages;
        }

    }
}
