using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssigment.Model
{
    public  class Book
    {
        private string Title  { get; set; }
        private string Author { get; set; } 
        private int Year { get; set; }    
        private string ISBN   { get; set; }

        public Book(string title, string author, int year,  string isbn)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year ; 
            this.ISBN = isbn; 
        }


        public string title
        {
            get { return title; }
            set { title = value; }
        }
        public string author
        {
            get { return author; }
            set { author = value; }
        }
        public int year
        {
            get { return year; }
            set { year = value; }
        }
        public string isbn
        {
            get { return isbn; }
            set { isbn = value; }

        }
        public void PrintBookInfo()
        {
           
            Console.WriteLine($"Title:  {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year:   {Year}");
            Console.WriteLine($"ISBN:   {ISBN}");
            Console.WriteLine("...................");
        }

        public bool IsOlderThan(int targetYear)
        {
            return this.year < targetYear;
        }






    }
}
