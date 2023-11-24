namespace P08Library.MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DetailsBookView), typeof(DetailsBookView));
            Routing.RegisterRoute(nameof(AddBookView), typeof(AddBookView));
        }
    }
}
