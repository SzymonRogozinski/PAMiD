using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using P06Shop.Shared.Auth;
using P06Shop.Shared.Services.AuthService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public partial class LoginViewModel : ObservableObject, INotifyPropertyChanged
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IAuthService _authService;

        public LoginViewModel(IServiceProvider serviceProvider, IAuthService authService) 
        { 
            _serviceProvider = serviceProvider;
            _authService = authService;
            _user = new UserLoginDTO();
            _message = string.Empty;
        }

        [ObservableProperty]
        private UserLoginDTO _user;
        public UserLoginDTO lUser
        {
            get => _user;
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }

        [ObservableProperty]
        private string _message;
        public string MessageCommunicate
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        [RelayCommand]
        public async void Login()
        {
            var response = await _authService.Login(lUser);
            if (!response.Success)
            {
                MessageCommunicate = response.Message;
            }
            else 
            {
                LibraryMainViewModel MainViewModel = _serviceProvider.GetService<LibraryMainViewModel>();
                LoginWindow lWindow = _serviceProvider.GetService<LoginWindow>();

                AuthorizedViewModel newAuthorized=new AuthorizedViewModel();
                newAuthorized.Token = response.Data;
                newAuthorized.HelloMessage = User.Email;

                //Secret
                string token = newAuthorized.Token;
                var secretResponse = await _authService.Secret(newAuthorized.Token);

                newAuthorized.Secret = secretResponse.Success ? secretResponse.Data : "Error while getting secret!";

                MainViewModel.Authorized = newAuthorized;

                MessageCommunicate = "You have been correctly logged in";
            }
        }

        [RelayCommand]
        public void Register()
        {
            RegisterWindow registerView = _serviceProvider.GetService<RegisterWindow>();

            registerView.Show();
        }

    }
}
