

using P06Shop.Shared;
using P06Shop.Shared.Library;
using P06Shop.Shared.Shop;
using P07Shop.DataSeeder;

namespace P05Shop.API.Services.BookDB
{
    public class SimpleBookDB : IBookDB
    {
        
        private Dictionary<int, Book> books;

        public SimpleBookDB() 
        {
            books = new Dictionary<int, Book>();
            //DataSeeder
            foreach (Book book in BookSeeder.GenerateProductData())
            {
                books.Add(book.id, book);
            }
        }

        public async Task<ServiceResponse<bool>> AddBook(Book book)
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

        public async Task<ServiceResponse<List<Book>>> GetAllBooks()
        {
            try
            {
                List<Book> bookList=new List<Book>();
                foreach (var book in this.books)
                {
                    bookList.Add(book.Value);
                }
                var response = new ServiceResponse<List<Book>>()
                {
                    Data = bookList,
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
                    Message = "Problem with data base",
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<Book>> GetBook(int id)
        {
            
            try
            {
                //Pobranie danych
                Book book = books[id];
                var response = new ServiceResponse<Book>()
                {
                    Data = book,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (ArgumentNullException)
            {
                return new ServiceResponse<Book>()
                {
                    Data = null,
                    Message = "Data base don't contain this book",
                    Success = false
                };
            }
            catch (Exception)
            {
                return new ServiceResponse<Book>()
                {
                    Data = null,
                    Message = "Problem with dataseeder library",
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<bool>> UpdateBook(Book book, int id)
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