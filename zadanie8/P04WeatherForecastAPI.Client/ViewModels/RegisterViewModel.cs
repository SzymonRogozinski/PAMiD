using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class RegisterViewModel : ObservableObject, INotifyPropertyChanged
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IAuthService _authService;

        public RegisterViewModel(IServiceProvider serviceProvider, IAuthService authService) 
        { 
            _serviceProvider = serviceProvider;
            _authService = authService;
            _user = new UserRegisterDTO();
            _message = string.Empty;
        }
        
        [ObservableProperty]
        private UserRegisterDTO _user;
        public UserRegisterDTO rUser
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
        public async Task RegisterAsync()
        {
            var response = await _authService.Register(rUser);
            if (!response.Success)
            {
                MessageCommunicate = response.Message;
            }
            else
            {
                RegisterWindow registerView = _serviceProvider.GetService<RegisterWindow>();
                MessageCommunicate = "You have been correctly registered";

            }
        }
    }
}
