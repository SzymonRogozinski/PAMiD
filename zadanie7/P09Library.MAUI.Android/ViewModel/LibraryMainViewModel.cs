using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P06Shop.Shared.Library;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.Services.LibraryServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Library.MAUI.Android
{
    public partial class LibraryMainViewModel : ObservableObject
    {
        private readonly ILibraryServices _libraryServices;
        private readonly IConnectivity _connectivity;
        private readonly IMessageDialogService _messageDialogService;
        private readonly DetailsBookView _detailBookView;

        public ObservableCollection<Book> Books { get; set; }

        //[ObservableProperty]
        public Book selectedBook { get; set; }

        public LibraryMainViewModel (ILibraryServices libraryServices, IMessageDialogService messageDialogService, IConnectivity connectivity, DetailsBookView detailBookView) 
        { 
            _libraryServices = libraryServices;
            _connectivity = connectivity;
            _messageDialogService= messageDialogService;
            Books = new ObservableCollection<Book>();
            _detailBookView = detailBookView;
            GetBooks();
        }

        [RelayCommand]
        public async Task GetBooks()
        {
            Books.Clear();
            if (_connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                _messageDialogService.ShowMessage("Internet not available!");
                return;
            }
            try
            {
                var booksResponse = await _libraryServices.GetAllBooksAsync();

                if (booksResponse.Success)
                {
                    foreach (var p in booksResponse.Data)
                    {
                        Books.Add(p);
                    }
                }
                else
                {
                    _messageDialogService.ShowMessage(booksResponse.Message);
                }
            }
            catch (Exception e) 
            {
                string error = e.Message;
                error = error != null ? error : "Error";
                _messageDialogService.ShowMessage(error);//e.Message);
            }

        }

        [RelayCommand]
        public async Task ShowDetails(Book book) 
        {
            if (_connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                _messageDialogService.ShowMessage("Internet not available!");
                return;
            }
            BookViewModel bookViewModel = new BookViewModel(book);
            await Shell.Current.GoToAsync(nameof(DetailsBookView), true, new Dictionary<string, object>
            {
                {"BookViewModel", bookViewModel },
                {"LibraryMainViewModel", this }
            });
            //SelectedBook = bookModel;
            /*SelectedProduct = product;*/
        }

        [RelayCommand]
        public async Task AddNewBook() 
        {
            if (_connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                _messageDialogService.ShowMessage("Internet not available!");
                return;
            }

            BookViewModel bookViewModel = new BookViewModel(new Book());
            await Shell.Current.GoToAsync(nameof(AddBookView), true, new Dictionary<string, object>
            {
                {"BookViewModel", bookViewModel },
                {"LibraryMainViewModel", this }
            });


        } 
    }
}
