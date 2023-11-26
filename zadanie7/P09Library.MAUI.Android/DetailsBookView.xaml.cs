namespace P09Library.MAUI.Android
{
    public partial class DetailsBookView:ContentPage
    {
        public DetailsBookView(DetailsBookViewModel context)
        {
            BindingContext = context;
            InitializeComponent();
        }
    }
}