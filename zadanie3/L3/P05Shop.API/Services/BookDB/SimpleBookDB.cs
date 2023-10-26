

using P06Shop.Shared.Library;

namespace P05Shop.API.Services.BookDB
{
    public class SimpleBookDB : IBookDB
    {
        private List<Book> books;

        public SimpleBookDB() { books = new List<Book>(); }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DeleteBook(int id)
        {
            books.RemoveAt(id);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books[id];
        }

        public void UpdateBook(Book book, int id)
        {
            books[id] = book;
        }
    }
}