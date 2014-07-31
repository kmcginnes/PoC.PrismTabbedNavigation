namespace PoC.PrismTabbedNavigation.Baz
{
    public partial class BazSidebar
    {
        public BazSidebar(BazSidebarViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
