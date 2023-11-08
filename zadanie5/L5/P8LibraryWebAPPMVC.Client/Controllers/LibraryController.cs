
using Microsoft.AspNetCore.Mvc;
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
            await _libraryServices.AddBookAsync(name,author,pages,genres);
			return RedirectToAction(nameof(Index));
		}

		[HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
			var book = await _libraryServices.GetBookAsync(id);

            //Copy data
            string genreList = "";
            int i;
			for (i = 0; i < book.genres.Count - 1; i++) 
            {
                genreList += book.genres[i].name + ",";
            }
			genreList += book.genres[i].name;
            model.genres = genreList;

			return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Update(string name, string author, int pages, string genres, int id)
        {
            var response=await _libraryServices.updateBookAsync(name,author,pages,genres,id);
			return RedirectToAction(nameof(Index));
		}

        [HttpGet]
        public async Task<IActionResult> Delete()
        {
			int id=model.detailedBook.id;
			await _libraryServices.removeBookAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}