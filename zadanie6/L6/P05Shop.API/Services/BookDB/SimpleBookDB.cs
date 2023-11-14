using P06Shop.Shared;
using P06Shop.Shared.Library;
using P07Shop.DataSeeder;

namespace P05Shop.API.Services.BookDB
{
    public class SimpleBookDB : IBookDB
    {
        
        private Dictionary<int, P06Shop.Shared.Library.Book> books;

        public SimpleBookDB() 
        {
            books = new Dictionary<int, P06Shop.Shared.Library.Book>();
            //DataSeeder
            foreach (P06Shop.Shared.Library.Book book in BookSeeder.GenerateProductData())
            {
                books.Add(book.id, book);
            }
        }

        public async Task<ServiceResponse<bool>> AddBook(P06Shop.Shared.Library.Book book)
        {
            try
            {
                //Dodanie
                books.Add(book.id, book);
                var response = new ServiceResponse<bool>()
                {
                    Data = true,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception)
            {
                return new ServiceResponse<bool>()
                {
                    Data = false,
                    Message = "Problem with adding new Book",
                    Success = false
                };
            }

        }

        public async Task<ServiceResponse<bool>> DeleteBook(int id)
        {
            
            try
            {
                //Usuniêcie
                books.Remove(id);
                var response = new ServiceResponse<bool>()
                {
                    Data = true,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (ArgumentNullException)
            {
                return new ServiceResponse<bool>()
                {
                    Data = false,
                    Message = "Data base don't contain this book",
                    Success = false
                };
            }
            catch (Exception)
            {
                return new ServiceResponse<bool>()
                {
                    Data = false,
                    Message = "Problem with data base",
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<List<P06Shop.Shared.Library.Book>>> GetAllBooks()
        {
            try
            {
                List<P06Shop.Shared.Library.Book> bookList = new List<P06Shop.Shared.Library.Book>();
                foreach (var book in this.books)
                {
                    bookList.Add(book.Value);
                }
                var response = new ServiceResponse<List<P06Shop.Shared.Library.Book>>()
                {
                    Data = bookList,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception)
            {
                return new ServiceResponse<List<P06Shop.Shared.Library.Book>>()
                {
                    Data = null,
                    Message = "Problem with data base",
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<P06Shop.Shared.Library.Book>> GetBook(int id)
        {
            
            try
            {
                //Pobranie danych
                P06Shop.Shared.Library.Book book = books[id];
                var response = new ServiceResponse<P06Shop.Shared.Library.Book>()
                {
                    Data = book,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (ArgumentNullException)
            {
                return new ServiceResponse<P06Shop.Shared.Library.Book>()
                {
                    Data = null,
                    Message = "Data base don't contain this book",
                    Success = false
                };
            }
            catch (Exception)
            {
                return new ServiceResponse<P06Shop.Shared.Library.Book>()
                {
                    Data = null,
                    Message = "Problem with dataseeder library",
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<bool>> UpdateBook(P06Shop.Shared.Library.Book book, int id)
        {
            try
            {
                //Aktualizacja
                books[id] = book;
                var response = new ServiceResponse<bool>()
                {
                    Data = true,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (ArgumentNullException)
            {
                return new ServiceResponse<bool>()
                {
                    Data = false,
                    Message = "Data base don't contain this book",
                    Success = false
                };
            }
            catch (Exception)
            {
                return new ServiceResponse<bool>()
                {
                    Data = false,
                    Message = "Problem with dataseeder library",
                    Success = false
                };
            }
        }
    }
}