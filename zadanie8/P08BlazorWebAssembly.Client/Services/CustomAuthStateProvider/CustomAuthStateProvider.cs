using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using P06Shop.Shared.Services.AuthService;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace P11BlazorWebAssembly.Client.Services.CustomAuthStateProvider
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly HttpClient _httpClient;
        private readonly TokenHolder _tokenHolder;

        public CustomAuthStateProvider(ILocalStorageService localStorageService, HttpClient httpClient, TokenHolder tokenHolder)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
            _tokenHolder = tokenHolder;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            string authToken = await _localStorageService.GetItemAsStringAsync("authToken");

            var identity = new ClaimsIdentity();
            _httpClient.DefaultRequestHeaders.Authorization = null;

            if (!string.IsNullOrEmpty(authToken))
            {
                try
                {
                    identity = new ClaimsIdentity(ParseClaimsFromJwt(authToken), "jwt");
                    _tokenHolder.token = authToken.Replace("\"", "");
                    //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken.Replace("\"", ""));
                }
                catch (Exception)
                {
                    await _localStorageService.RemoveItemAsync("authToken");
                    _tokenHolder.token = "";
                    identity = new ClaimsIdentity();
                }
            }

            var user = new ClaimsPrincipal(identity);
            var state = new AuthenticationState(user);
            NotifyAuthenticationStateChanged(Task.FromResult(state));
            return state;    
        }

        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            var claims = keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()));
            return claims;
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
    }
}
