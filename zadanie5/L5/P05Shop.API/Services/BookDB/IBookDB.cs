

using P06Shop.Shared;
using P06Shop.Shared.Library;

namespace P05Shop.API.Services.BookDB
{
    public interface IBookDB
    {
        public Task<ServiceResponse<Book>> GetBook(int id);
        public Task<ServiceResponse<List<Book>>> GetAllBooks();
        public Task<ServiceResponse<bool>> DeleteBook(int id);
        public Task<ServiceResponse<bool>> AddBook(Book book);
        public Task<ServiceResponse<bool>> UpdateBook(Book book,int id);

    }
}