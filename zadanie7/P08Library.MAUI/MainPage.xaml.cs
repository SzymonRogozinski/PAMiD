using P08Library.MAUI.ViewModel;

namespace P08Library.MAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage(LibraryMainViewModel context)
        {
            InitializeComponent();
            BindingContext = context;
        }

    }

}
