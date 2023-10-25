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
    }

    public class Genre
    {
        public string name { get; set; }
    }
}
