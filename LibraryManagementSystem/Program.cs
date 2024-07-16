using System;

namespace LibraryManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book("The Summer I Turned Pretty", "Collen", 256985);
            book.displayBookDetails();
        }
    }
}
