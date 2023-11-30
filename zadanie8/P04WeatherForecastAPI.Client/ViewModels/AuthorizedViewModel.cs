using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public class AuthorizedViewModel
    {
        public string Token { get; set; }
        public string HelloMessage { get; set; }
        public string Secret { get; set; }
    }
}
