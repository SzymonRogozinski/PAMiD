namespace P09Library.MAUI.Android
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
