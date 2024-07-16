using System;
using System.Diagnostics.Metrics;

namespace LibraryManagementSystem
{
    public delegate void bookOperation(Book book);
    public class Library{
        private const int MAXIMUM_BORROW_DAYS = 7;
        private const int FINE_PER_DAY = 50;
        private List<Book> books;
        public List<Book>Books { 
            get { return this.books; }
            set { this.books = value; }
        }


        public event bookOperation bookAdded;
        public Library()
        {
            books = new List<Book>();
        }

        public void addBook(Book book)
        {
            books.Add(book);
            if (bookAdded != null)
            {
                bookAdded(book);
            }
        }
        public void displayAllBooks()
        {
            int counter = 1;
            Console.WriteLine("********Books********");
            foreach (Book book in books)
            {
                Console.WriteLine("****Book " + counter++ + "****");
                book.displayBookDetails();
            }

        }
        public Book? findBookByIsbn(long isbn)
        {
            foreach (var book in books)
            {
                if(book.Isbn == isbn)
                    return book;
            }
            return null;

            //bool found = false;
            //foreach (Book book in books)
            //{
            //    if (book.Isbn == isbn)
            //    {
            //        Console.WriteLine("****Book of ISBN " + isbn + "****");
            //        Console.WriteLine("Title: " + book.Title);
            //        Console.WriteLine("Author: " + book.Author);
            //        found = true;
            //    }
            //    if (found)
            //    {
            //        break;
            //    }
            //}
            //if (!found)
            //{
            //    Console.WriteLine("Book Not Found!");
            //}

        }
        public Book this[int index]
        {
            get { 
                return books[index];
            }
        }
        public static Library operator +(Library lib1, Library lib2)
        {
            Library result = new Library();
            var newList = lib1.Books.Concat(lib2.Books);
            result.Books=newList.ToList();
            return result;
        }

         public class LibraryStatistics{
            public static int totalNumberOfBooks(Library library)
            {
                return library.books.Count();
            }
         }
    }
}
