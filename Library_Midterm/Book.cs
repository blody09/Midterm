using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Midterm
{
    class Book
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book ("The Hobbit","JRR Tolkien","Fantasy"),
            new Book ("The Fellow Ship of the Ring","JRR Tolkien","Fantasy"),
            new Book ("The Two Towers","JRR Tolkien","Fantasy"),
            new Book ("The Return of the King","JRR Tolkien","Fantasy"),
            new Book ("Everybody Poops","Amanda Mayer","Childrens"),
            new Book ("The Theif of Always","Clive Barker","Childrens"),
            new Book ("Go the F*** to Sleep","Adams Mansbach","Childrens"),
            new Book ("Star Bellied Sneeches","Dr.Seuss","Childrens"),
            new Book ("The Dark Tower","Stephen King","Fantasy"),
            new Book ("Patriot Games","Tom Clancy","Thriller"),
            new Book ("Rainbow Six","Tom Clancy","Thriller"),
            new Book ("Red Rabbit","Tom Clancy","Thriller"),
            new Book ("Pride and the Prejedice","Jane Austen","Romance"),
            new Book ("Outlander","Diana Gabaldon","Romance"),
            


        };
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool Status { get; set; }
        public DateTime DueDate { get; set; }

        public Book()
        {

        }
        
        public Book(string title, string author, string genre, bool status = true)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Status = status;
            DueDate = DateTime.Now;

        }

        public void CheckOut()
        {
            Console.WriteLine();
            Status = false;
            DueDate = DateTime.Now.AddDays(14);
            Console.WriteLine($"The book is due: {DueDate.ToShortDateString()} \n");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("WARNING: you will be charged 10 cents for");
            Console.WriteLine("everday this book is not returned past the due date.");
            Console.ResetColor();
            Console.WriteLine();
        }

        public void CheckIn()
        {
            Status = true;

        }
        
    }
}
