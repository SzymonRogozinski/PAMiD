using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public partial class LibraryMainViewModel : ObservableObject
    {
        private DetailedBookViewModel _detailedBookViewModel;
        public ObservableCollection<SimplyfiedBookViewModel> books { get; set; }
        private readonly IServiceProvider _serviceProvider;

        public LibraryMainViewModel(IServiceProvider serviceProvider) 
        {
            books=new ObservableCollection<SimplyfiedBookViewModel> ();
            _serviceProvider = serviceProvider;
        }
    }
}
