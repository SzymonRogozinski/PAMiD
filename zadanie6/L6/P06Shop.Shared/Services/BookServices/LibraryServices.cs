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

        public async Task<ServiceResponse<bool>> AddBookAsync(string name, string author, int pages, string genres)
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

            Book book = new Book(name, author, pages, genreList);
            string Input = JsonConvert.SerializeObject(book);
            StringContent data = new StringContent(Input, System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_appSettings.BaseProductEndpoint.AddProductEndpoint,data);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<bool>>(json);
            return result;
        }

        public async Task<ServiceResponse<List<Book>>> GetAllBooksAsync()
        {
            var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.GetAllProductsEndpoint);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<List<Book>>>(json);
            return result;
        }

        public async Task<ServiceResponseBookCut<List<Book>>> GetBookPageAsync(int size, int page) 
        {
            var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.GetAllProductsEndpoint+$"?size={size}&page={page}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponseBookCut<List<Book>>>(json);
            return result;
        }

        public async Task<ServiceResponse<Book>> GetBookAsync(int id)
        {
			if (id<=0)
			{
				throw new ArgumentException();
			}
			var response = await _httpClient.GetAsync(_appSettings.BaseProductEndpoint.GetOneProductEndpoint + $"?id={id}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<Book>>(json);
            return result;
        }

        public async Task<ServiceResponse<bool>> removeBookAsync(int id)
        {
			if (id <= 0)
			{
				throw new ArgumentException();
			}
			var response =await _httpClient.DeleteAsync(_appSettings.BaseProductEndpoint.DeleteProductEndpoint + $"?id={id}");
            var succes =response.IsSuccessStatusCode;
            ServiceResponse<bool> result = new ServiceResponse<bool>();
            result.Success = succes;
            result.Message=response.StatusCode.ToString();
            return result;
        }

        public async Task<ServiceResponse<bool>> updateBookAsync(string name, string author, int pages, string genres, int id)
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

            Book book = new Book(name, author, pages, genreList);
            book.id = id;
            string Input = JsonConvert.SerializeObject(book);
            StringContent data = new StringContent(Input, System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync(_appSettings.BaseProductEndpoint.UpdateProductsEndpoint,data);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<bool>>(json);
            return result;
        }
    }
}