namespace PoC.PrismTabbedNavigation.Baz
{
    public partial class BazView
    {
        public BazView(BazViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
