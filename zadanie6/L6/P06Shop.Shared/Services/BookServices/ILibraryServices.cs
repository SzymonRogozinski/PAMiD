using P06Shop.Shared.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Services.LibraryServices
{
    public interface ILibraryServices
    {
        Task<ServiceResponse<List<Book>>> GetAllBooksAsync();
        Task<ServiceResponseBookCut<List<Book>>> GetBookPageAsync(int size, int page);
        Task<ServiceResponse<Book>> GetBookAsync(int id);
        Task<ServiceResponse<bool>> removeBookAsync(int id);
        Task<ServiceResponse<bool>> AddBookAsync(string name, string author, int pages, string genres);
        Task<ServiceResponse<bool>> updateBookAsync(string name, string author, int pages, string genres, int id);
    }
}
