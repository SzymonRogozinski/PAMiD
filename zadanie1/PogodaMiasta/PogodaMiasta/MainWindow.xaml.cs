using P04WeatherForecastAPI.Client.Models;
using P04WeatherForecastAPI.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P04WeatherForecastAPI.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AccuWeatherService accuWeatherService;
        public MainWindow()
        {
            InitializeComponent();
            accuWeatherService = new AccuWeatherService();
        }

        private async void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //Dodanie migającego loadingu
            pbSearching.Visibility = Visibility.Visible;
            City[] cities = await accuWeatherService.GetLocations(txtCity.Text);
            pbSearching.Visibility = Visibility.Hidden;
            // standardowy sposób dodawania elementów
            //lbData.Items.Clear();
            //foreach (var c in cities)
            //    lbData.Items.Add(c.LocalizedName);

            // teraz musimy skorzystac z bindowania danych bo chcemy w naszej kontrolce przechowywac takze id miasta 
            lbData.ItemsSource = cities;
        }

        private async void lbData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCity = (City)lbData.SelectedItem;
            if (selectedCity != null)
            {
                txtCity.Text =selectedCity.LocalizedName;
                //Wyświetlenie migającego loadingu
                pbWaitingForSearchedTown.Visibility = Visibility.Visible;
                var weather = await accuWeatherService.GetCurrentConditions(selectedCity.Key);
                lblCityName.Content = selectedCity.LocalizedName;
                double tempValue = weather.Temperature.Metric.Value;
                lblTemperatureValue.Content = Convert.ToString(tempValue);
                //Wyświetlenie migającego loadingu
                pbWaitingForSearchedTown.Visibility = Visibility.Hidden;
            }
        }

        //Wyświetla sąsiednie miasta
        private async void btnLoadTown_Click(object sender, RoutedEventArgs e)
        {
            var selectedCity = (City)lbData.SelectedItem;
            if (selectedCity != null)
            {
                //Wyświetlenie migającego loadingu
                pbWaitingForTowns.Visibility = Visibility.Visible;
                string[] city_list=await accuWeatherService.GetNeighbourCities(selectedCity.Key);
                lvNeighbouringCities.ItemsSource=city_list;
                //Wyświetlenie migającego loadingu
                pbWaitingForTowns.Visibility = Visibility.Hidden;
            }
        }

        //Wyświetla więcej informacji
        private async void btnMoreInfo_Click(object sender, RoutedEventArgs e)
        {
            var selectedCity = (City)lbData.SelectedItem;
            if (selectedCity != null)
            {
                //Wyświetlenie migającego loadingu
                pbWaitingForDeatils.Visibility = Visibility.Visible;
                string[] weather_list = await accuWeatherService.GetDetailWeather(selectedCity.Key);
                lblDayWth.Content= weather_list[0];
                lblNightWth.Content = weather_list[1];
                var curr= await accuWeatherService.GetCurrentWeather(selectedCity.Key);
                lblCurrentWth.Content = curr;
                //Wyświetlenie migającego loadingu
                pbWaitingForDeatils.Visibility = Visibility.Hidden;
            }
        }

        //Wyświetla alert
        private async void btnCheckAlert_Click(object sender, RoutedEventArgs e)
        {
            var selectedCity = (City)lbData.SelectedItem;
            if (selectedCity != null)
            {
                //Wyświetlenie migającego loadingu
                pbWaitingForAlerts.Visibility = Visibility.Visible;
                string[] alert = await accuWeatherService.GetWeatherAlert(selectedCity.Key);
                if (alert==null)
                {
                    lblAlertStatus.Content = "No alert";
                }
                else 
                {
                    lblAlertStatus.Content = "Alert!";
                    lblAlertDate.Content = alert[0];
                    lblAlertType.Content = alert[1];
                    lblAlertValue.Content = alert[2];
                }
                //Wyświetlenie migającego loadingu
                pbWaitingForAlerts.Visibility = Visibility.Hidden;
            }
        }

        //Wyświetla lokalizację na bazie ip
        private async void btnCheckIP_Click(object sender, RoutedEventArgs e)
        {

            //Wyświetlenie migającego loadingu
            pbWaitingForIP.Visibility = Visibility.Visible;
            string ip_string = await accuWeatherService.GetIPLocation();
            lblIPLocation.Content = ip_string;
            //Wyświetlenie migającego loadingu
            pbWaitingForIP.Visibility = Visibility.Hidden;
        }
    }
}