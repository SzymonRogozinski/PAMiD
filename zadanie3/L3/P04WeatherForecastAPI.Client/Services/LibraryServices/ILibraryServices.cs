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
        void removeBookAsync(int id);
        void AddBookAsync(/*Todo*/);
        void updateBookAsync(/*Todo*/int id);

    }
}
