using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using P04WeatherForecastAPI.Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace P04WeatherForecastAPI.Client.Services
{
    internal class AccuWeatherService
    {
        private const string base_url = "http://dataservice.accuweather.com";
        private const string autocomplete_endpoint = "locations/v1/cities/autocomplete?apikey={0}&q={1}&language{2}";
        private const string current_conditions_endpoint = "currentconditions/v1/{0}?apikey={1}&language{2}";

        private const string neibour_cities_endpoint = "locations/v1/cities/neighbors/{0}?apikey={1}%20&language={2}&details=false";
        private const string det_weather_endpoint = "forecasts/v1/daily/1day/{0}?apikey={1}%20&language={2}&metric=true";
        private const string current_weather_endpoint = "currentconditions/v1/{0}?apikey={1}&language={2}";
        private const string alarms_weather_endpoint = "alarms/v1/1day/{0}?apikey={1}&language={2}";
        private const string ip_location_endpoint = "locations/v1/cities/ipaddress?apikey={0}&q={1}&language{2}";


        private const string api_key = "BXREHEO1Lz6rPy3ff7V2S53bLbIASv8o";
        //string api_key;
        //private const string language = "pl";
        string language;

        public AccuWeatherService()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<App>()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetings.json"); 

            var configuration = builder.Build();
            //api_key = configuration["api_key"];
            language = configuration["default_language"];
        }


        public async Task<City[]> GetLocations(string locationName)
        {
            string uri = base_url + "/" + string.Format(autocomplete_endpoint, api_key, locationName, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                City[] cities = JsonConvert.DeserializeObject<City[]>(json);
                return cities;

            }
        }

        public async Task<Weather> GetCurrentConditions(string cityKey)
        {
            string uri = base_url + "/" + string.Format(current_conditions_endpoint, cityKey, api_key,language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                Weather[] weathers= JsonConvert.DeserializeObject<Weather[]>(json);
                return weathers.FirstOrDefault();
            }
        }

        public async Task<string[]> GetNeighbourCities(string cityKey) 
        {
            string uri = base_url + "/" + string.Format(neibour_cities_endpoint, cityKey, api_key, language);
            using (HttpClient client = new HttpClient())
            {
                //Wczytanie danych
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                //Odpakowanie ich
                dynamic cities = JsonConvert.DeserializeObject<dynamic>(json);
                List<string> cityList=new List<string>();
                //Wczytanie pojedyńczego obiektu z listy
                foreach (dynamic city in cities) 
                {
                    //Dodanie string z nazwą miasta
                    cityList.Add(city["LocalizedName"].ToString());
                }
                return cityList.ToArray();
            }
        }

        public async Task<string[]> GetDetailWeather(string cityKey)
        {
            string uri = base_url + "/" + string.Format(det_weather_endpoint, cityKey, api_key, language);
            using (HttpClient client = new HttpClient())
            {
                //Wczytanie danych
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                //Odpakowanie ich
                dynamic weather = JsonConvert.DeserializeObject<dynamic>(json);
                List<string> weathers = new List<string>();
                dynamic v1 = weather["DailyForecasts"][0].Day.IconPhrase.ToString();
                weathers.Add(v1);
                v1 = weather["DailyForecasts"][0].Night.IconPhrase.ToString();
                weathers.Add(v1);
                return weathers.ToArray();
            }
        }

        public async Task<string> GetCurrentWeather(string cityKey)
        {
            string uri = base_url + "/" + string.Format(current_weather_endpoint, cityKey, api_key, language);
            using (HttpClient client = new HttpClient())
            {
                //Wczytanie danych
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                //Odpakowanie ich
                dynamic Curr_weather = JsonConvert.DeserializeObject<dynamic>(json);
                string weather = Curr_weather[0]["WeatherText"].ToString();
                return weather;
            }
        }

        public async Task<string[]> GetWeatherAlert(string cityKey)
        {
            string uri = base_url + "/" + string.Format(alarms_weather_endpoint, cityKey, api_key, language);
            using (HttpClient client = new HttpClient())
            {
                //Wczytanie danych
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                if (json=="[]")
                    return null;
                //Odpakowanie ich
                dynamic alerts = JsonConvert.DeserializeObject<dynamic>(json);
                

                List<string> alarm = new List<string>();
                string v1 = alerts["Date"].ToString();
                alarm.Add(v1);
                v1 = alerts["Alarms"].AlarmType.ToString();
                alarm.Add(v1);
                v1 = alerts["Alarms"].Value.Metric.Value.ToString()+ alerts["Alarms"].Value.Metric.Unit.ToString();
                alarm.Add(v1);
                return alarm.ToArray();
            }
        }

        public async Task<string> GetIPLocation()
        {
            //Pobranie ip użytkownika
            var externalIp = await GetExternalIpAddress();
            externalIp = externalIp ?? IPAddress.Loopback;

            string uri = base_url + "/" + string.Format(ip_location_endpoint, api_key, externalIp, language);
            using (HttpClient client = new HttpClient())
            {
                //Wczytanie danych
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                //Odpakowanie ich
                dynamic Ip_data = JsonConvert.DeserializeObject<dynamic>(json);
                string weather = Ip_data["LocalizedName"].ToString();
                return weather;
            }
        }

        private static async Task<IPAddress?> GetExternalIpAddress()
        {
            var externalIpString = (await new HttpClient().GetStringAsync("http://icanhazip.com"))
                .Replace("\\r\\n", "").Replace("\\n", "").Trim();
            if (!IPAddress.TryParse(externalIpString, out var ipAddress)) return null;
            return ipAddress;
        }
    }
}
