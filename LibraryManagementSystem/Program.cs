using System;

namespace LibraryManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book("The Summer I Turned Pretty", "Collen", 256985);
            Book book2 = new Book("The Summer I Turned Pretty part 2", "Collen", 11111);
            Library library = new Library();
            Library library2 = new Library();
            //library.bookAdded += Library_bookAdded;
            library.addBook(book1);
            library2.addBook(book2);
            var combLib = library + library2;
            combLib.displayAllBooks();

            //            library.displayAllBooks();
            //library.findBookByIsbn(11111);
            //book.displayBookDetails();
            Console.WriteLine(Library.LibraryStatistics.totalNumberOfBooks(library));
        } 

        private static void Library_bookAdded(Book book)
        {
            Console.WriteLine("Book Added Successfully");
        }
    }
}
