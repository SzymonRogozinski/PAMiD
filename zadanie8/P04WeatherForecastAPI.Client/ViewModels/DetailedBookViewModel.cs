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
        public string name { get; set; }
        public string author { get; set; }
        public int pages { get; set;}
        public List<string> genres { get; set;}
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
