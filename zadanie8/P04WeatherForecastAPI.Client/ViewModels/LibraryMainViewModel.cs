using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using P04WeatherForecastAPI.Client.Services.LibraryServices;
using P06Shop.Shared.Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public partial class LibraryMainViewModel : ObservableObject, INotifyPropertyChanged
    {
        public ObservableCollection<SimplyfiedBookViewModel> books { get; set; }
        private readonly IServiceProvider _serviceProvider;
        private readonly ILibraryServices _libraryServices;
        private MainWindow MainWindowReference;

        public LibraryMainViewModel(IServiceProvider serviceProvider, ILibraryServices libraryServices) 
        {
            books=new ObservableCollection<SimplyfiedBookViewModel> ();
            _serviceProvider = serviceProvider;
            _libraryServices = libraryServices;
            _authorizedViewModel=new AuthorizedViewModel();
        }

        [ObservableProperty]
        private AuthorizedViewModel _authorizedViewModel;

        public AuthorizedViewModel Authorized
        {
            get => _authorizedViewModel;
            set
            {
                _authorizedViewModel = value;
                OnPropertyChanged();
            }
        }

        public void AddReference(MainWindow MainWindowReference)
        {
            this.MainWindowReference= MainWindowReference;
        }

        [RelayCommand]
        public void Login() 
        {
            LoginWindow loginView = _serviceProvider.GetService<LoginWindow>();
            LoginViewModel loginViewModel = _serviceProvider.GetService<LoginViewModel>();

            loginView.Show();
        }

        [ObservableProperty]
        private DetailedBookViewModel _detailedBookViewModel;

        public DetailedBookViewModel DetailedBook 
        { 
            get => _detailedBookViewModel; 
            set 
            { 
                _detailedBookViewModel = value; 
                OnPropertyChanged(); 
            } 
        }

        private SimplyfiedBookViewModel _selectedBook;

        public SimplyfiedBookViewModel SelectedBook
        {
            get => _selectedBook;
            set
            {
                _selectedBook = value;
                OnPropertyChanged();
                LoadBook();
            }
        }

        [RelayCommand]
        public async void LoadAllBooks()
        {
            var bookList = await _libraryServices.GetAllBooksAsync();
            if (bookList == null) 
            {
                return;
            }
            books.Clear();
            foreach(Book book in bookList)
            {
                books.Add(new SimplyfiedBookViewModel(book));
            }
        }

        [RelayCommand]
        public async void LoadBook()
        {
            if (SelectedBook == null) 
            {
                DetailedBook = new DetailedBookViewModel(new Book("","",0,new List<Genre>()));
            }
            else
            {
                var book = await _libraryServices.GetBookAsync(SelectedBook.reference);
                if (book == null)
                {
                    return;
                }
                DetailedBook = new DetailedBookViewModel(book);
            }
            
        }

        [RelayCommand]
        public async void AddBook()
        {
            string[] bookInfo = MainWindowReference.GetBookStrings();
            var response = await _libraryServices.AddBookAsync(bookInfo[0], bookInfo[1], ((int)Int32.Parse(bookInfo[2])), bookInfo[3]);
            if (!response)
            {
                return;
            }
            LoadAllBooks();
        }

        [RelayCommand]
        public async void RemoveBook()
        {
            var response = await _libraryServices.removeBookAsync(SelectedBook.reference);
            if (!response)
            {
                return;
            }
            LoadAllBooks();
        }

        [RelayCommand]
        public async void UpdateBook()
        {
            string[] bookInfo = MainWindowReference.GetBookStrings();
            var response = await _libraryServices.updateBookAsync(bookInfo[0], bookInfo[1], ((int)Int32.Parse(bookInfo[2])), bookInfo[3], SelectedBook.reference);
            if (!response)
            {
                return;
            }
            LoadAllBooks();
        }

    }
}
