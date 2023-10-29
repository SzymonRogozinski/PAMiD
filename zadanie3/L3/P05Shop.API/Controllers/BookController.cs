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
        private static int nextId = 1;

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
            if (!res.Success)
            {
                return StatusCode(500, $"Internal server error {res.Message}");
            }
            else 
            { 
                return Ok(res);
            }
        }

        //https://localhost:7230/api/Book/get?id=$
        [HttpGet("get")]
        public Book GetBook([FromQuery] int id)
        {
            var res = _bookDB.GetBook(id);
            return res;
        }

        //https://localhost:7230/api/Book/add?name=sample&author=au&pages=$$$genres=*,*,*
        [HttpGet("add")]
        public void AddBook([FromQuery] string name, [FromQuery] string author, [FromQuery] int pages, [FromQuery] string genres)
        {
            string[] sliceGen = genres.Trim().Split(',');
            List<Genre> genreList=new List<Genre>();
            foreach (string genre in sliceGen) { genreList.Add(new Genre(genre));}
            _bookDB.AddBook(new Book(name,author,pages,genreList,nextId));
            nextId++;
        }

        //https://localhost:7230/api/Book/delete?&id=$
        [HttpDelete("delete")]
        public void deleteBook([FromQuery] int id)
        {
            _bookDB.DeleteBook(id);
        }

        //https://localhost:7230/api/Book/update?name=sample&author=au&pages=$$$genres=*,*,*&id=$
        [HttpPut("update")]
        public void updateBook([FromQuery] string name, [FromQuery] string author, [FromQuery] int pages, [FromQuery] string genres, [FromQuery] int id)
        {
            string[] sliceGen = genres.Trim().Split(',');
            List<Genre> genreList = new List<Genre>();
            foreach (string genre in sliceGen) { genreList.Add(new Genre(genre)); }
            _bookDB.UpdateBook(new Book(name, author, pages, genreList, id),id);
        }
    }
}