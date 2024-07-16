using System;

namespace LibraryManagementSystem
{
    public class Library{
        private const int MAXIMUM_BORROW_DAYS = 7;
        private const int FINE_PER_DAY = 50;
        private List<Book> books;
        public Library(List<Book>books)
        {
            this.books = books;
        }

        public void addBook()
        {

        }
        public void displayAllBooks()
        {

        }
        public void findBookByIsbn()
        {

        }
        public Book this[int index]
        {
            get { 
                return books[index];
            }
            set { }
        }
    }
}
