using Microsoft.AspNetCore.Mvc;
using P05Shop.API.Services.BookDB;
using P06Shop.Shared;
using P06Shop.Shared.Library;
using P06Shop.Shared.Services.BookServices;
using P06Shop.Shared.Services.ProductService;
using P06Shop.Shared.Shop;

namespace P05Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller    //https://localhost:7230/api/Book
    {
        //private readonly IBookServices _bookService;
        private static IBookDB _bookDB=new SimpleBookDB();
        private static int nextId = 0;

        public BookController(IBookDB bookDB)
        {
            //_bookService = bookService;
            //_bookDB=bookDB;
        }

        //https://localhost:7230/api/Book/getAll
        [HttpGet("getAll")]
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
        }

        //https://localhost:7230/api/Book/get?id=$
        [HttpGet("get")]
        public async Task<ActionResult<ServiceResponse<Book>>> GetBook([FromQuery] int id)
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
        [HttpGet("add")]
        public async Task<ActionResult<ServiceResponse<bool>>> AddBook([FromQuery] string name, [FromQuery] string author, [FromQuery] int pages, [FromQuery] string genres)
        {
            string[] sliceGen = genres.Trim().Split(',');
            List<Genre> genreList=new List<Genre>();
            foreach (string genre in sliceGen) 
            {
                if (genre != "") 
                {
                    genreList.Add(new Genre(genre));
                } 
            }
            var res=await _bookDB.AddBook(new Book(name,author,pages,genreList,nextId));
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
        [HttpGet("delete")]
        public async Task<ActionResult<ServiceResponse<bool>>> deleteBook([FromQuery] int id)
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
        [HttpGet("update")]
        public async Task<ActionResult<ServiceResponse<bool>>>  updateBook([FromQuery] string name, [FromQuery] string author, [FromQuery] int pages, [FromQuery] string genres, [FromQuery] int id)
        {
            string[] sliceGen = genres.Trim().Split(',');
            List<Genre> genreList = new List<Genre>();
            foreach (string genre in sliceGen)
            {
                if (genre != "")
                {
                    genreList.Add(new Genre(genre));
                }
            }
            var res = await _bookDB.UpdateBook(new Book(name, author, pages, genreList, id),id);
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