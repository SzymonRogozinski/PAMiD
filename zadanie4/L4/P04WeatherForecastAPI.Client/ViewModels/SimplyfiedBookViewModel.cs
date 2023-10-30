using P06Shop.Shared.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public class SimplyfiedBookViewModel
    {
        public string Title { get; }
        public int reference {  get; }

        public SimplyfiedBookViewModel(Book book) 
        {
            Title = book.name;
            reference = book.id;
        }
    }
}
