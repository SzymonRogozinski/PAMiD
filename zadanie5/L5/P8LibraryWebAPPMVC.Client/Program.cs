using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using P06Shop.Shared.Configuration;
using P06Shop.Shared.Services.LibraryServices;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var appSettings = builder.Configuration.GetSection(nameof(AppSettings));
var appSettingsSection = appSettings.Get<AppSettings>();

var uriBuilder = new UriBuilder(appSettingsSection.BaseAPIUrl)
{
    Path = appSettingsSection.BaseProductEndpoint.Base_url,
};
//Microsoft.Extensions.Http
builder.Services.AddHttpClient<ILibraryServices, LibraryServices>(client => client.BaseAddress = uriBuilder.Uri);
builder.Services.Configure<AppSettings>(appSettings);


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Library}/{action=Index}/{id?}");

app.Run();
