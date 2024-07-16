using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public class Book:Iborrowable
    {
        private string title;
        private string author;
        private long isbn;
        public bookStatus Status { get; set; }


        public Book(string title, string author, long isbn)
        {
            this.title = title;
            this.author = author;   
            this.isbn = isbn;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public long Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public void displayBookDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author:{Author}");
            Console.WriteLine($"ISBN: {Isbn}");
        }
        public enum bookStatus
        {
            Available,
            Borrowed,
            Reserved
        }

        public void borrowBook()
        {
            //book.Status = bookStatus.Borrowed;
            Console.WriteLine("Book is borrowed");
        }

        public void returnBook()
        {
            Console.WriteLine("Book is returned");
        }
    }
}
