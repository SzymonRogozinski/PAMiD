using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using P04WeatherForecastAPI.Client.Services.LibraryServices;
using P04WeatherForecastAPI.Client.ViewModels;
using P06Shop.Shared.Configuration;
using P06Shop.Shared.Services.AuthService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace P04WeatherForecastAPI.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IServiceProvider _serviceProvider;
        IConfiguration _configuration;
        public App()
        {
            //wczytanie appsettings.json do konfiguracji 
            var builder = new ConfigurationBuilder()
              .AddUserSecrets<App>()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json");
            _configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();

        }

        private void ConfigureServices(IServiceCollection services)
        {
            var appSettingsSection = ConfigureAppSettings(services);
            ConfigureAppServices(services);
            ConfigureViewModels(services);
            ConfigureViews(services);
            ConfigureHttpClients(services, appSettingsSection);
        }

        private AppSettings ConfigureAppSettings(IServiceCollection services)
        {
            // pobranie appsettings z konfiguracji i zmapowanie na klase AppSettings 
            //Microsoft.Extensions.Options.ConfigurationExtensions
            var appSettings = _configuration.GetSection(nameof(AppSettings));
            var appSettingsSection = appSettings.Get<AppSettings>();
            services.Configure<AppSettings>(appSettings);
            return appSettingsSection;
        }

        private void ConfigureAppServices(IServiceCollection services)
        {
            // konfiguracja serwisów 
            services.AddSingleton<ILibraryServices,LibraryServices>();
            services.AddSingleton<IAuthService, AuthService>();

        }

        private void ConfigureViewModels(IServiceCollection services)
        {

            // konfiguracja viewModeli 
            services.AddSingleton<LibraryMainViewModel>();
            services.AddTransient<LoginViewModel>();
            services.AddTransient<RegisterViewModel>();
        }

        private void ConfigureViews(IServiceCollection services)
        {
            // konfiguracja okienek 
            services.AddTransient<MainWindow>();
            services.AddTransient<LoginWindow>();
            services.AddTransient<RegisterWindow>();
        }

        private void ConfigureHttpClients(IServiceCollection services, AppSettings appSettingsSection)
        {
            var uriBuilder = new UriBuilder(appSettingsSection.BaseAPIUrl)
            {
                Path = appSettingsSection.BaseProductEndpoint.Base_url,
            };
            //Microsoft.Extensions.Http
            services.AddHttpClient<ILibraryServices, LibraryServices>(client => client.BaseAddress = uriBuilder.Uri);

            var nextUriBuilder = new UriBuilder(appSettingsSection.BaseAPIUrl)
            {
                Path = appSettingsSection.AuthEndpoint.Base_url,
            };

            services.AddHttpClient<IAuthService,AuthService>(client => client.BaseAddress = nextUriBuilder.Uri);

        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

    }
}
