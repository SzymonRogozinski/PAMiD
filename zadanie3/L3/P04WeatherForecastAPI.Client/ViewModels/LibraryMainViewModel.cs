using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        }

        public void AddReference(MainWindow MainWindowReference)
        {
            this.MainWindowReference= MainWindowReference;
        }

        [ObservableProperty]
        private DetailedBookViewModel _detailedBookViewModel;

        public DetailedBookViewModel DetailedBook { get; set; }

        private SimplyfiedBookViewModel _selectedBook;

        public SimplyfiedBookViewModel SelectedBook
        {
            get => _selectedBook;
            set
            {
                _selectedBook = value;
                OnPropertyChanged();
            }
        }

        [RelayCommand]
        public async void LoadAllBooks()
        {
            var bookList = await _libraryServices.GetAllBooksAsync();
            books.Clear();
            foreach(Book book in bookList)
            {
                books.Add(new SimplyfiedBookViewModel(book));
            }
        }

        [RelayCommand]
        public async void LoadBook()
        {
            var book = await _libraryServices.GetBookAsync(SelectedBook.reference);
            _detailedBookViewModel= new DetailedBookViewModel(book);
        }

        [RelayCommand]
        public async void AddBook()
        {
            string[] bookInfo = MainWindowReference.GetBookStrings();
            await _libraryServices.AddBookAsync(bookInfo[0], bookInfo[1], ((int)Int32.Parse(bookInfo[2])), bookInfo[3].Split(','));
            LoadAllBooks();
            //_detailedBookViewModel = new DetailedBookViewModel(book);
        }

        [RelayCommand]
        public async void RemoveBook()
        {
            await _libraryServices.removeBookAsync(SelectedBook.reference);
            LoadAllBooks();
        }

        [RelayCommand]
        public async void UpdateBook()
        {
            string[] bookInfo = MainWindowReference.GetBookStrings();
            await _libraryServices.updateBookAsync(bookInfo[0], bookInfo[1], ((int)Int32.Parse(bookInfo[2])), bookInfo[3].Split(','), SelectedBook.reference);
            LoadAllBooks();
        }

    }
}
