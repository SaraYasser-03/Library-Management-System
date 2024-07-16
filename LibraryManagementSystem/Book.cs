using System;

namespace LibraryManagementSystem
{
    public class Book
    {
        private string title;
        private string author;
        private long isbn;

        public Book(string title, string author, long isbn)
        {
            this.title = title;
            this.author = author;   
            this.isbn = isbn;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public long Isbn { get; set; }

        public void displayBookDetails()
        {
            Console.WriteLine("****Book Details****");
            Console.WriteLine("Title:" + this.title);
            Console.WriteLine("Author:" + this.author);
            Console.WriteLine("ISBN:" + this.isbn);
            
        }
    }
}
