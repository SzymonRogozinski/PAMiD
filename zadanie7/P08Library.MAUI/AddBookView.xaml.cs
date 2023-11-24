using P08Library.MAUI.ViewModel;

namespace P08Library.MAUI 
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