
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using P06Shop.Shared;
using P06Shop.Shared.Library;
using P06Shop.Shared.Services.LibraryServices;
using P8LibraryWebAPPMVC.Client.Models;

namespace P08LibraryWebAPPMVC.Client.Controllers
{
    public class LibraryController : Controller 
    {
        private readonly ILibraryServices _libraryServices;
        private static LibraryModel model;

        public LibraryController(ILibraryServices LibraryServices)
        {
            _libraryServices = LibraryServices;

        }

        [HttpGet]
        //GetAll
        public async Task<IActionResult> Index()
        {
            var books = await _libraryServices.GetAllBooksAsync();
            model = new LibraryModel();
            model.SetBookList(books);
            model.detailedBook = books.First();

			return books != null ?
						  View(model) :
						  Problem("Entity set 'LibraryContext.Books'  is null.");
        }

		[HttpGet]
        public IActionResult AddPage()
        {
            model.newName = "";
            model.newAuthor = "";
            model.newPages = 0;
            model.newGenres = "";
            return View(model);
        }


		[HttpGet]
		public async  Task<IActionResult> Add(string name, string author, int pages, string genres)
		{
            try
            {
				var response = await _libraryServices.AddBookAsync(name, author, pages, genres);
				if (!response)
				{
                    return StatusCode(500);
				}

				return RedirectToAction(nameof(Index));
			}
			catch(Exception ex)
            {
				return BadRequest("Illegal Argument!");
			}
		}

		[HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            Book book;
			try
			{
				book = await _libraryServices.GetBookAsync(id);
				if (book==null)
				{
					return StatusCode(500);
				}
			}
			catch (Exception ex)
			{
				return BadRequest("Client error!");
			}

            //Copy data
            string genreList = "";
            int i;
			for (i = 0; i < book.genres.Count - 1; i++) 
            {
                genreList += book.genres[i].name + ",";
            }
			genreList += book.genres[i].name;
            model.detailedBook = await _libraryServices.GetBookAsync(id);
            model.genres = genreList;

			return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Update(string name, string author, int pages, string genres, int id)
        {
			try
			{
				var response = await _libraryServices.updateBookAsync(name, author, pages, genres, id);
				if (!response)
				{
					return StatusCode(500);
				}
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				return BadRequest("Illegal Argument!");
			}

		}

        [HttpGet]
        public async Task<IActionResult> Delete()
        {
			try
			{
				int id = model.detailedBook.id;
				var response = await _libraryServices.removeBookAsync(id);
				if (!response)
				{
					return StatusCode(500);
				}
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				return BadRequest("Client error!");
			}

        }
    }
}