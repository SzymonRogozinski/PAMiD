using P04WeatherForecastAPI.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogodaMiasta.ViewModel
{
    public class WeatherModel
    {
        private string _cityName;
        private string _temperature;

        public WeatherModel(string temperature,string city)
        {
            //_cityName = city;
            //_temperature = weather.Temperature.ToString();
            CityName=city;
            Temperature=temperature;
        }

        public string CityName { get; set; }

        public string Temperature { get; set; }
    }
}
