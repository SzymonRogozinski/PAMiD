using P04WeatherForecastAPI.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogodaMiasta.ViewModel
{
    public class NearbyCityModel
    {
        public string LocalizedName { get; set; }

        public NearbyCityModel(string city)
        {
            LocalizedName = city;
        }

    }
}
