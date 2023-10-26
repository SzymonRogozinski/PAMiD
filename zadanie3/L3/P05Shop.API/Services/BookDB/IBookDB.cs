

using P06Shop.Shared.Library;

namespace P05Shop.API.Services.BookDB
{
    public interface IBookDB
    {
        public Book GetBook(int id);
        public List<Book> GetAllBooks();
        public void DeleteBook(int id);
        public void AddBook(Book book);
        public void UpdateBook(Book book,int id);

    }
}