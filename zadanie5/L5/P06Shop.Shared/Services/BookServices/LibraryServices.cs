using P06Shop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using P06Shop.Shared.Library;
using System.Xml.Linq;
using P06Shop.Shared.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace P06Shop.Shared.Services.LibraryServices
{
    public class LibraryServices : ILibraryServices
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
            if (name == null || author==null || genres==null || pages==0) { 
                throw new ArgumentException(); 
            }
            string[] sliceGen = genres.Trim().Split(',');
            List<Genre> genreList=new List<Genre>();
            foreach (string genre in sliceGen) 
            {
                if (genre != "") 
                {
                    genreList.Add(new Genre(genre));
                } 
            }

            P06Shop.Shared.Library.Book book = new P06Shop.Shared.Library.Book(name, author, pages, genreList, -1);
            string Input = JsonConvert.SerializeObject(book);
            StringContent data = new StringContent(Input, System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_appSettings.BaseProductEndpoint.AddProductEndpoint,data);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<bool>>(json);
            if (!result.Success)
            {
                System.Console.WriteLine(result.Message);
            }
            return result.Success;

        }

        public async Task<IEnumerable<P06Shop.Shared.Library.Book>> GetAllBooksAsync()
        {
            var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.GetAllProductsEndpoint);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<List<P06Shop.Shared.Library.Book>>>(json);
            if (result.Success)
            {
                return (IEnumerable<P06Shop.Shared.Library.Book>)result.Data;
            }
            else
            {
                System.Console.WriteLine(result.Message);
                return null;
            }
        }

        public async Task<P06Shop.Shared.Library.Book> GetBookAsync(int id)
        {
			if (id<=0)
			{
				throw new ArgumentException();
			}
			var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.GetOneProductEndpoint + $"?id={id}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<P06Shop.Shared.Library.Book>>(json);
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
			if (id <= 0)
			{
				throw new ArgumentException();
			}
			var response =await _httpClient.DeleteAsync(_appSettings.BaseProductEndpoint.DeleteProductEndpoint + $"?id={id}");
            var succes =response.IsSuccessStatusCode;
            if (!succes)
            {
                System.Console.WriteLine(response.StatusCode);
            }
            return succes;
        }

        public async Task<bool> updateBookAsync(string name, string author, int pages, string genres, int id)
        {
			if (name == null || author == null || genres == null || pages == 0 || id<=0)
			{
				throw new ArgumentException();
			}
			string[] sliceGen = genres.Trim().Split(',');
            List<Genre> genreList = new List<Genre>();
            foreach (string genre in sliceGen)
            {
                if (genre != "")
                {
                    genreList.Add(new Genre(genre));
                }
            }

            P06Shop.Shared.Library.Book book = new P06Shop.Shared.Library.Book(name, author, pages, genreList, id);
            string Input = JsonConvert.SerializeObject(book);
            StringContent data = new StringContent(Input, System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync(_appSettings.BaseProductEndpoint.UpdateProductsEndpoint,data);
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