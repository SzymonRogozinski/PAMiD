using P06Shop.Shared.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.Services.LibraryServices
{
    public interface ILibraryServices
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task<Book> GetBookAsync(int id);
        Task<bool> removeBookAsync(int id);
        Task<bool> AddBookAsync(string name, string author,int pages, string[] genres);
        Task<bool> updateBookAsync(string name, string author, int pages, string[] genres,int id);

    }
}
