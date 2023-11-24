using P06Shop.Shared.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Services.BookServices
{
    public interface IBookServices
    {
        Task<ServiceResponse<List<Library.Book>>> GetBooksAsync();
    }
}
