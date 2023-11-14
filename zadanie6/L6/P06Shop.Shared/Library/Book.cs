using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Library
{
    public class Book
    {
        public string name { get; set; }
        public string author { get; set; }
        public int pages { get; set; }
        public List<Genre> genres { get; set; }
        public int id { get; set; }

		public Book(string name, string author, int pages, List<Genre> genres)
		{
			this.name = name;
			this.author = author;
			this.pages = pages;
			this.genres = genres;
		}

		public Book(){}

        public string GenreToString() {
            string genreList = "";
            int i;
            for (i = 0; i < genres.Count-1; i++) 
            {
                genreList += genres[i].name + ",";
            }
            genreList += genres[i].name;
            return genreList;
        }

        public static explicit operator Book(ServiceResponse<Book> v)
        {
            throw new NotImplementedException();
        }
    }

    public class Genre
    {
        public string name { get; }

        public Genre(string name)
        {
            this.name = name;
        }
    }
}
