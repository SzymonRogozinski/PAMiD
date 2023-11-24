using Microsoft.AspNetCore.Mvc;
using P05Shop.API.Services.BookDB;
using P06Shop.Shared;
using P06Shop.Shared.Library;
using P06Shop.Shared.Services.BookServices;
using System.Collections.Generic;

namespace P05Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller    //https://localhost:7230/api/Book
    {
        //private readonly IBookServices _bookService;
        private IBookDB _bookDB;
        private static int nextId = 11;

        public BookController(IBookDB bookDB)
        {
            this._bookDB=bookDB;
            //_bookService = bookService;
            //_bookDB=bookDB;
        }

        //https://localhost:7230/api/Book/getAll
        /*[HttpGet("getAll")]
        public async Task<ActionResult<ServiceResponse<IEnumerable<Book>>>> GetBooks()
        {
            var res = await _bookDB.GetAllBooks();
            if (res.Success)
            {
                return Ok(res);
            }
            else 
            {
                return StatusCode(500, $"Internal server error {res.Message}");
                
            }
        }*/

        //https://localhost:7230/api/Book/getAll
        [HttpGet("getAll")]
        public async Task<ActionResult<ServiceResponse<List<Book>>>> GetBooks([FromQuery] int? size, [FromQuery] int? page)
        {
            var res = await _bookDB.GetAllBooks();
            if (!size.HasValue || !page.HasValue) {
                if (res.Success)
                {
                    return Ok(res);
                }
                else
                {
                    return StatusCode(500, $"Internal server error {res.Message}");

                }
            }

            int PageIsReal, SizeIsReal;
            PageIsReal = page.Value;
            SizeIsReal = size.Value;

            if (res.Success)
            {
                List<Book> books = new List<Book>();
                int start = SizeIsReal * (PageIsReal - 1);
                int end = (SizeIsReal * PageIsReal) > res.Data.Count ? res.Data.Count : (SizeIsReal * PageIsReal);

                for (int i = start; i < end; i++)
                {
                    books.Add(res.Data[i]);
                }
                var bookPacked = new ServiceResponseBookCut<List<Book>>()
                {
                    Data = books,
                    Message = "ok",
                    Success = true,
                    MaxPage = (int)Math.Ceiling(((double) res.Data.Count / SizeIsReal))
                };
                return Ok(bookPacked);
            }
            else
            {
                return StatusCode(500, $"Internal server error {res.Message}");

            }
        }

        //https://localhost:7230/api/Book/get?id=$
        [HttpGet("get")]
        public async Task<ActionResult<ServiceResponse<P06Shop.Shared.Library.Book>>> GetBook([FromQuery] int id)
        {
            var res = await _bookDB.GetBook(id);
            if (res.Success)
            {
                return Ok(res);
                
            }
            else if (res.Message == "Data base don't contain this book")
            {
                return StatusCode(469, $"Client error {res.Message}");
            }
            else
            {
                return StatusCode(500, $"Internal server error {res.Message}");
            }
 
        }

        //https://localhost:7230/api/Book/add?name=sample&author=au&pages=$$$genres=*,*,*
        [HttpPost("add")]
        public async Task<ActionResult<ServiceResponse<bool>>> AddBook(P06Shop.Shared.Library.Book book)//[FromQuery] string name, [FromQuery] string author, [FromQuery] int pages, [FromQuery] string genres)
        {
            var res=await _bookDB.AddBook(new Book(book.name, book.author, book.pages, book.genres));
            if (res.Success)
            {
                nextId++;
                return Ok(res);
            }
            else 
            {
                return StatusCode(500, $"Internal server error {res.Message}");
            }
            
        }

        //https://localhost:7230/api/Book/delete?&id=$
        [HttpDelete("delete")]
        public async Task<ActionResult<ServiceResponse<bool>>> deleteBook( int id)
        {
            var res=await _bookDB.DeleteBook(id);
            if (res.Success)
            {
                return Ok(res);

            }
            else if (res.Message== "Data base don't contain this book")
            {
                return StatusCode(469, $"Client error {res.Message}");
            }
            else
            {
                return StatusCode(500, $"Internal server error {res.Message}");
            }
        }

        //https://localhost:7230/api/Book/update?name=sample&author=au&pages=$$$genres=*,*,*&id=$
        [HttpPut("update")]
        public async Task<ActionResult<ServiceResponse<bool>>>  updateBook(Book book)
        {

            var res = await _bookDB.UpdateBook(book, book.id);
            if (res.Success)
            {
                return Ok(res);
                
            }
            else if (res.Message == "Data base don't contain this book")
            {
                return StatusCode(469, $"Client error {res.Message}");
            }
            else
            {
                return StatusCode(500, $"Internal server error {res.Message}");
            }
        }
    }
}