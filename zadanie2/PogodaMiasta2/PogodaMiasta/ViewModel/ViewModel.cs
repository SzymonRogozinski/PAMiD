using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using P04WeatherForecastAPI.Client.Models;
using P04WeatherForecastAPI.Client.Services;
using P04WeatherForecastAPI.Client.ViewModels;
using PogodaMiasta.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogodaMiasta.ViewModel
{
    public partial class ViewModel : ObservableObject
    {
        private IWeather AWS;

        public ViewModel(IWeather AWS)
        {
            this.AWS = AWS;
            Cities = new ObservableCollection<CityViewModel>();
            NearbyCities = new ObservableCollection<NearbyCityModel>();
        }

        public ObservableCollection<CityViewModel> Cities { get; set; }

        [RelayCommand]
        public async void SearchTown_Click(string locationName)
        {
            var cities = await AWS.GetLocations(locationName);
            Cities.Clear();
            foreach (var city in cities)
                Cities.Add(new CityViewModel(city));
        }

        [ObservableProperty]
        private WeatherModel _weatherView;
        public WeatherModel WeatherModel
        {
            get { return _weatherView; }
            set
            {
                _weatherView = value;
                OnPropertyChanged();
            }
        }

        private CityViewModel _selectedCity;
        public CityViewModel SelectedCity
        {
            get => _selectedCity;
            set
            {
                _selectedCity = value;
                OnPropertyChanged();
                LoadWeather();
            }
        }

        private async void LoadWeather()
        {
            if (SelectedCity != null)
            {
                var weather = await AWS.GetCurrentConditions(SelectedCity.Key);
                WeatherModel = new WeatherModel(weather.Temperature.Metric.Value.ToString(), _selectedCity.LocalizedName);
            }
        }

        public ObservableCollection<NearbyCityModel> NearbyCities { get; set; }

        [RelayCommand]
        public async void NearbyTown_Click()
        { 
            string[] citiesNames=await AWS.GetNeighbourCities(SelectedCity.Key);
            NearbyCities.Clear();
            foreach (string city in citiesNames)
            {
                NearbyCities.Add(new NearbyCityModel(city));
            }
        }

        [ObservableProperty]
        private DetailModel _dayWeat;

        public DetailModel DayWeather
        { get => _dayWeat; set { _dayWeat = value; OnPropertyChanged(); } }

        [ObservableProperty]
        private DetailModel _nightWeat;

        public DetailModel NightWeather
        { get => _nightWeat; set { _nightWeat = value; OnPropertyChanged(); } }

        [ObservableProperty]
        private DetailModel _currentWeat;

        public DetailModel CurrentWeather
        { get => _currentWeat; set { _currentWeat = value; OnPropertyChanged(); } }

        [RelayCommand]
        public async void MoreInfo_Click()
        {
            string[] details=await AWS.GetDetailWeather(SelectedCity.Key);
            DayWeather = new DetailModel(details[0]);
            NightWeather = new DetailModel(details[1]);
            CurrentWeather= new DetailModel(await AWS.GetCurrentWeather(SelectedCity.Key));
        }

        [ObservableProperty]
        private AlertModel _alert;

        public AlertModel AlertInfo { get => _alert; set { _alert = value; OnPropertyChanged(); } }

        [RelayCommand]
        public async void CheckAlert_Click()
        {
            string[] alerts=await AWS.GetWeatherAlert(SelectedCity.Key);
            if (alerts == null)
            {
                AlertInfo = new AlertModel("No alert");
            }
            else 
            {
                AlertInfo=new AlertModel("Alert!", alerts[0], alerts[1], alerts[2]);
            }
        }

        [ObservableProperty]
        private DetailModel _ipAdress;

        public DetailModel IPLocation { get => _ipAdress; set { _ipAdress = value; OnPropertyChanged(); } }

        [RelayCommand]
        public async void CheckIP_Click()
        {
            string loc=await AWS.GetIPLocation();
            IPLocation = new DetailModel(loc);
        }

    }
}
