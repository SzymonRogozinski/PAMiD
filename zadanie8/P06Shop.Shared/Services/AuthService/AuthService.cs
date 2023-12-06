using Microsoft.Extensions.Options;
using P06Shop.Shared.Auth;
using P06Shop.Shared.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Services.AuthService
{
    public class AuthService : IAuthService
    {
    
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly TokenHolder _tokenHolder;

        public AuthService(HttpClient httpClient, IOptions<AppSettings> appSettings, TokenHolder tokenHolder)
        {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
            _tokenHolder = tokenHolder;
            _httpClient.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", _tokenHolder.token));

        }

        public async Task<ServiceResponse<string>> Secret() 
        {
            var result = await _httpClient.GetAsync(_appSettings.AuthEndpoint.SecretEndpoint);

            var json = await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();

            if (json.Success)
            {
                return new ServiceResponse<string>
                {
                    Data = json.Data,
                    Success = true
                };
            }
            else
            {
                return new ServiceResponse<string>
                {
                    Success = false,
                    Message = json.Message
                };
            }
        }

        public async Task<ServiceResponse<string>> Login(UserLoginDTO userLoginDto)
        {
            if (string.IsNullOrEmpty(userLoginDto.Email) || string.IsNullOrEmpty(userLoginDto.Password))
            {
                return new ServiceResponse<string> { Success = false, Message = "Some data is not filled!" };
            }
            var result = await _httpClient.PostAsJsonAsync(_appSettings.AuthEndpoint.LoginEndpoint, userLoginDto);

            var data =  await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();

            return data;
        }

        public async Task<ServiceResponse<int>> Register(UserRegisterDTO userRegisterDTO)
        {
            if (string.IsNullOrEmpty(userRegisterDTO.Username) || string.IsNullOrEmpty(userRegisterDTO.Email) || string.IsNullOrEmpty(userRegisterDTO.Password) || string.IsNullOrEmpty(userRegisterDTO.ConfirmPassword))
            {
                return new ServiceResponse<int> { Success = false, Message = "Some data is not filled!" };
            } else if (!userRegisterDTO.Password.Equals(userRegisterDTO.ConfirmPassword))
            {
                return new ServiceResponse<int> { Success = false, Message = "Password are not the same!" };
            }

            var result = await _httpClient.PostAsJsonAsync(_appSettings.AuthEndpoint.RegisterEndpoint, userRegisterDTO);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }

        public async Task<ServiceResponse<bool>> ChangePassword(string newPassword)
        {
            if (string.IsNullOrEmpty(newPassword))
            {
                return new ServiceResponse<bool> { Success = false, Message = "Some data is not filled!" };
            }
            var result = await _httpClient.PostAsJsonAsync(_appSettings.AuthEndpoint.ChangePasswordEndpoint, newPassword);

            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }
    }
}
