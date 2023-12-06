using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using P06Shop.Shared.Configuration;
using P06Shop.Shared.Services.AuthService;
using P06Shop.Shared.Services.LibraryServices;
using P08BlazorWebAssembly.Client;
using P11BlazorWebAssembly.Client.Services.CustomAuthStateProvider;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var appSettings = builder.Configuration.GetSection(nameof(AppSettings));
var appSettingsSection = appSettings.Get<AppSettings>();

var uriBuilder = new UriBuilder(appSettingsSection.BaseAPIUrl)
{
    Path = appSettingsSection.BaseProductEndpoint.Base_url,
};

builder.Services.AddBlazoredLocalStorage();

//Microsoft.Extensions.Http
builder.Services.AddHttpClient<ILibraryServices, LibraryServices>(client => client.BaseAddress = uriBuilder.Uri);

// autorization
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

var authUriBuilder = new UriBuilder(appSettingsSection.BaseAPIUrl)
{
    Path = appSettingsSection.AuthEndpoint.Base_url,
};

builder.Services.AddHttpClient<IAuthService, AuthService>(client => client.BaseAddress = authUriBuilder.Uri);


builder.Services.AddSingleton<TokenHolder, TokenHolder>();
builder.Services.AddSingleton<IOptions<AppSettings>>(new OptionsWrapper<AppSettings>(appSettingsSection));


await builder.Build().RunAsync();