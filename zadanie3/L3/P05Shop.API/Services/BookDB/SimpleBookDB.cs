

using P06Shop.Shared;
using P06Shop.Shared.Library;
using P06Shop.Shared.Shop;
using P07Shop.DataSeeder;

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

        public async Task<ServiceResponse<List<Book>>> GetAllBooks()
        {
            try
            {
                var response = new ServiceResponse<List<Book>>()
                {
                    Data = books,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception)
            {
                return new ServiceResponse<List<Book>>()
                {
                    Data = null,
                    Message = "Problem with dataseeder library",
                    Success = false
                };
            }
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