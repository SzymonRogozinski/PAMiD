using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using P04WeatherForecastAPI.Client.Configuration;
using P06Shop.Shared.Shop;
using P06Shop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using P06Shop.Shared.Library;
using System.Xml.Linq;

namespace P04WeatherForecastAPI.Client.Services.LibraryServices
{
    internal class LibraryServices : ILibraryServices
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly string baseURL;
        public LibraryServices(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
            baseURL = _appSettings.BaseAPIUrl+"/"+_appSettings.BaseProductEndpoint.Base_url;
        }

        public async Task<bool> AddBookAsync(string name, string author, int pages, string[] genres)
        {
            string gen = "";
            foreach (string g in genres)
            {
                gen += g+",";
            }
            //add?name=1&author=1&pages=1&genres=1
            //add?name=1&author=1&pages=1&genres=1,
            /*string tt = _appSettings.BaseProductEndpoint.AddProductEndpoint + $"?name={name}&author={author}&pages={pages}&genres={gen}";*/

            /*List<Genre> g= new List<Genre>();
            foreach(string s in genres) 
            { 
                g.Add(new Genre(s));
            }*/

            var data = new Dictionary<string, string>
            {
                {"name", name},
                {"author", author},
                {"pages", ""+pages},
                {"genres", author}
            };

            //Book b = new Book(name,author,pages,g,11);
            //var company = JsonConvert.SerializeObject(b);
            //var requestContent = new StringContent(company, Encoding.UTF8, "application/json");

            var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.AddProductEndpoint + $"?name={name}&author={author}&pages={pages}&genres={gen}");
            //await _httpClient.PostAsync(_appSettings.BaseProductEndpoint.AddProductEndpoint, new FormUrlEncodedContent(data));
            //var json = await response.Content.ReadAsStringAsync();
            return false;
            //var result = JsonConvert.DeserializeObject<ServiceResponse<List<Product>>>(json);
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.GetAllProductsEndpoint);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<List<Book>>>(json);
            return (IEnumerable<Book>)result.Data;
        }

        public async Task<Book> GetBookAsync(int id)
        {
            var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.GetOneProductEndpoint + $"?id={id}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<Book>>(json);
            return (Book)result;
        }

        public async Task<bool> removeBookAsync(int id)
        {
            var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.DeleteProductEndpoint + $"?id={id}");
            var json = await response.Content.ReadAsStringAsync();
            return false;
            //var result = JsonConvert.DeserializeObject<ServiceResponse<Book>>(json);
        }

        public async Task<bool> updateBookAsync(string name, string author, int pages, string[] genres, int id)
        {
            string gen = "";
            foreach (string g in genres)
            {
                gen += g + ",";
            }
            var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.UpdateProductsEndpoint + $"?name={name}&author={author}&pages={pages}genres={gen}&id={id}");
            var json = await response.Content.ReadAsStringAsync();
            return false;
        }
    }
}