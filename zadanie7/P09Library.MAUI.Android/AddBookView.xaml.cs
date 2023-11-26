namespace P09Library.MAUI.Android
{
    public partial class AddBookView : ContentPage
    {
        public AddBookView(DetailsBookViewModel context)
        {
            BindingContext = context;
            InitializeComponent();
        }
    }
}