using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P05Shop.API.Services.BookDB;
using P06Shop.Shared.Library;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.Services.LibraryServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace P08Library.MAUI.ViewModel
{
    [QueryProperty(nameof(BookViewModel), "BookViewModel")]
    [QueryProperty(nameof(LibraryMainViewModel), "LibraryMainViewModel")]

    public partial class DetailsBookViewModel : ObservableObject
    {
        ILibraryServices _libraryServices;
        IConnectivity _connectivity;
        private readonly IMessageDialogService _messageDialogService;
        LibraryMainViewModel _libraryMainViewModel;
        BookViewModel _bookViewModel;

        public DetailsBookViewModel(ILibraryServices libraryServices, IMessageDialogService messageDialogService, IConnectivity connectivity)
        {
            _libraryServices = libraryServices;
            _connectivity = connectivity;
            _messageDialogService = messageDialogService;
        }

        [ObservableProperty]
        public BookViewModel bookViewModel;

        public LibraryMainViewModel LibraryMainViewModel
        {
            get
            {
                return _libraryMainViewModel;
            }
            set
            {
                _libraryMainViewModel = value;
            }
        }

        private bool ValidateBook() 
        {
            if (BookViewModel.name == null || BookViewModel.author == null || BookViewModel.genresString == null)
            {
                return false;
            }
            else if (BookViewModel.name == "" || BookViewModel.author == "" || BookViewModel.genresString == "")
            {
                return false;
            } 
            else if (BookViewModel.pages<=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        [RelayCommand]
        public async Task addBook()
        {
            if (!ValidateBook())
            {
                _messageDialogService.ShowMessage("Input data is not correct!");
                return;
            }
            var response = await _libraryServices.AddBookAsync(BookViewModel.name, BookViewModel.author, BookViewModel.pages, BookViewModel.genresString);
            if (response.Success)
            {
                await LibraryMainViewModel.GetBooks();
                await Shell.Current.GoToAsync("../", true);
            }
            else
            {
                _messageDialogService.ShowMessage(response.Message);
            }

        }

        [RelayCommand]
        public async Task deleteBook() 
        {
            var response = await _libraryServices.removeBookAsync(BookViewModel.id);
            if (response.Success)
            {
                await LibraryMainViewModel.GetBooks();
                await Shell.Current.GoToAsync("../", true);
            }
            else 
            {
                _messageDialogService.ShowMessage(response.Message);
            }
            
        }

        [RelayCommand]
        public async Task updateBook()
        {
            if (!ValidateBook())
            {
                _messageDialogService.ShowMessage("Input data is not correct!");
                return;
            }
            var response = await _libraryServices.updateBookAsync(BookViewModel.name,BookViewModel.author,BookViewModel.pages,BookViewModel.genresString,BookViewModel.id);
            if (response.Success)
            {
                await LibraryMainViewModel.GetBooks();
                await Shell.Current.GoToAsync("../", true);
            }
            else
            {
                _messageDialogService.ShowMessage(response.Message);
            }
        }

        [RelayCommand]
        public async Task goBack()
        {
            await Shell.Current.GoToAsync("../", true);
        }
    }
}
