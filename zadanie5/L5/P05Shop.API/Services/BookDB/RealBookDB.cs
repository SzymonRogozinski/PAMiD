using Microsoft.EntityFrameworkCore;
using P05Shop.API.Models;
using P06Shop.Shared;
using P06Shop.Shared.Library;
using P07Shop.DataSeeder;

namespace P05Shop.API.Services.BookDB
{
    public class RealBookDB : IBookDB
    {

        private Dictionary<int, P06Shop.Shared.Library.Book> books;
        private readonly DataContext _dataContext;

        public RealBookDB(DataContext context)
        {
            /*books = new Dictionary<int, P06Shop.Shared.Library.Book>();
            //DataSeeder
            foreach (P06Shop.Shared.Library.Book book in BookSeeder.GenerateProductData())
            {
                books.Add(book.id, book);
            }*/
            _dataContext = context;
        }

        public async Task<ServiceResponse<bool>> AddBook(P06Shop.Shared.Library.Book book)
        {
            try
            {
                //Dodanie
                /*books.Add(book.id, book);
                var response = new ServiceResponse<bool>()
                {
                    Data = true,
                    Message = "Ok",
                    Success = true
                };*/
                _dataContext.Books.Add(book);
                await _dataContext.SaveChangesAsync();
                return new ServiceResponse<bool>() { Data = true, Success = true };
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
                //UsuniÍcie
                /*books.Remove(id);
                var response = new ServiceResponse<bool>()
                {
                    Data = true,
                    Message = "Ok",
                    Success = true
                };

                return response;*/
                var book = new Book() { id = id };
                _dataContext.Books.Attach(book);
                _dataContext.Books.Remove(book);
                await _dataContext.SaveChangesAsync();

                return new ServiceResponse<bool>() { Data = true, Success = true };
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
                /*List<P06Shop.Shared.Library.Book> bookList = new List<P06Shop.Shared.Library.Book>();
                
                foreach (var book in this.books)
                {
                    bookList.Add(book.Value);
                }*/

                var bookList = await _dataContext.Books.ToListAsync();
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
                //P06Shop.Shared.Library.Book book = books[id];
                Book book = _dataContext.Books.Find(id);

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
                /*books[id] = book;
                var response = new ServiceResponse<bool>()
                {
                    Data = true,
                    Message = "Ok",
                    Success = true
                };

                return response;*/

                var bookToEdit = new Book() { id = book.id };
                _dataContext.Books.Attach(bookToEdit);

                bookToEdit.name = book.name;
                bookToEdit.author = book.author;
                bookToEdit.pages= book.pages;
                bookToEdit.genres = book.genres;

                await _dataContext.SaveChangesAsync();
                return new ServiceResponse<bool> { Data = true, Success = true };
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