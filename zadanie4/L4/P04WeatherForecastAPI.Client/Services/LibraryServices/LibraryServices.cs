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

        public async Task<bool> AddBookAsync(string name, string author, int pages, string genres)
        {
            var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.AddProductEndpoint + $"?name={name}&author={author}&pages={pages}&genres={genres}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<bool>>(json);
            if (!result.Success)
            {
                System.Console.WriteLine(result.Message);
            }
            return result.Success;

        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.GetAllProductsEndpoint);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<List<Book>>>(json);
            if (result.Success)
            {
                return (IEnumerable<Book>)result.Data;
            }
            else
            {
                System.Console.WriteLine(result.Message);
                return null;
            }
        }

        public async Task<Book> GetBookAsync(int id)
        {
            var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.GetOneProductEndpoint + $"?id={id}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<Book>>(json);
            if (result.Success)
            {
                return (Book)result.Data;
            }
            else
            {
                System.Console.WriteLine(result.Message);
                return null;
            }
        }

        public async Task<bool> removeBookAsync(int id)
        {
            var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.DeleteProductEndpoint + $"?id={id}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<bool>>(json);
            if (!result.Success)
            {
                System.Console.WriteLine(result.Message);
            }
            return result.Success;
        }

        public async Task<bool> updateBookAsync(string name, string author, int pages, string genres, int id)
        {
            var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.UpdateProductsEndpoint + $"?name={name}&author={author}&pages={pages}&genres={genres}&id={id}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<bool>>(json);
            if (!result.Success)
            {
                System.Console.WriteLine(result.Message);
            }
            return result.Success;
        }
    }
}