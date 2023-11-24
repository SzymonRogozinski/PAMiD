using P08Library.MAUI.ViewModel;

namespace P08Library.MAUI 
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