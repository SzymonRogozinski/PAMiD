using P06Shop.Shared.Library;

namespace P8LibraryWebAPPMVC.Client.Models
{
	public class LibraryModel
	{
		public Book detailedBook {  get; set; }
		public List<BookShortcut> bookList { get; set;}
		
		//String textbox for Book modifying
		public string genres { get; set; }

		//String textbox for Book Adding
		public string newName { get; set; }
		public string newAuthor { get; set; }
		public int newPages { get; set; }
		public string newGenres { get; set; }

		public void SetBookList(IEnumerable<Book> books) 
		{ 
			this.bookList=new List<BookShortcut>();
			foreach (var book in books) 
			{
				this.bookList.Add(new BookShortcut(book.name, book.id));
			}
		}
	}

	public class BookShortcut
	{
		public string Title { get; set; }
		public int id { get; set; }

		public BookShortcut(string title, int id)
		{
			Title = title;
			this.id = id;
		}
	}
}
