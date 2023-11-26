using Microsoft.Extensions.Logging;
using P06Shop.Shared.Configuration;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.Services.LibraryServices;

namespace P09Library.MAUI.Android
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            ConfigureServices(builder.Services);
            return builder.Build();
        }



        private static void ConfigureServices(IServiceCollection services)
        {
            var appSettingsSection = ConfigureAppSettings(services);
            ConfigureAppServices(services);
            ConfigureViewModels(services);
            ConfigureViews(services);
            ConfigureHttpClients(services, appSettingsSection);
        }

        private static AppSettings ConfigureAppSettings(IServiceCollection services)
        {
            var appSettingsSection = new AppSettings()
            {
                BaseAPIUrl = "https://localhost:7230",
                BaseProductEndpoint = new BaseProductEndpoint()
                {
                    Base_url = "api/Book/",
                    GetAllProductsEndpoint = "getAll",
                    GetOneProductEndpoint = "get",
                    AddProductEndpoint = "add",
                    DeleteProductEndpoint = "delete",
                    UpdateProductsEndpoint = "update",
                },
            };

            if (DeviceInfo.Platform==DevicePlatform.Android)
            {
                appSettingsSection.BaseAPIUrl = "https://10.0.2.2:7230";
            }
            services.AddSingleton(appSettingsSection);

            return appSettingsSection;
        }

        private static void ConfigureAppServices(IServiceCollection services)
        {
            services.AddSingleton<IConnectivity>(Connectivity.Current);

            // konfiguracja serwisów 
            services.AddSingleton<ILibraryServices, LibraryServices>();
            services.AddSingleton<IMessageDialogService, MauiMessageDialogService>();

        }

        private static void ConfigureViewModels(IServiceCollection services)
        {

            // konfiguracja viewModeli
            services.AddSingleton<LibraryMainViewModel>();
            services.AddTransient<DetailsBookViewModel>();

            // services.AddSingleton<BaseViewModel,MainViewModelV3>();
        }

        private static void ConfigureViews(IServiceCollection services)
        {
            // konfiguracja okienek 
            services.AddSingleton<MainPage>();
            services.AddTransient<DetailsBookView>();
            services.AddTransient<AddBookView>();
        }

        private static void ConfigureHttpClients(IServiceCollection services, AppSettings appSettingsSection)
        {
            var uriBuilder = new UriBuilder(appSettingsSection.BaseAPIUrl)
            {
                Path = appSettingsSection.BaseProductEndpoint.Base_url,
            };
            //Microsoft.Extensions.Http
            services.AddHttpClient<ILibraryServices, LibraryServices>(client => client.BaseAddress = uriBuilder.Uri);
        }
    }
}
