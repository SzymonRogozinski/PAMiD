using P06Shop.Shared.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public class DetailedBookViewModel
    {
        public string name { get; }
        public string author { get;}
        public int pages { get;}
        public List<string> genres { get;}
        public int id { get;}

        public DetailedBookViewModel(Book book)
        {
            this.name = book.name;
            this.author = book.author;
            this.pages = book.pages;
            this.genres = new List<string>();
            foreach (Genre genre in book.genres)
            {
                genres.Add(genre.name);
            }
            this.id = book.id;
        }

    }
}
