using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Library
{
    public class BookViewModel
    {

        public string name { get; set; }
        public string author { get; set; }
        public int pages { get; set; }
        public string genresString { get; set; }
        public int id { get; set; }

        public BookViewModel(){}

        public BookViewModel(Book book)
        {
            name = book.name;
            author = book.author;
            pages = book.pages;
            id = book.id;
            genresString = book.GenreToString();

        }
    }
}
