namespace PoC.PrismTabbedNavigation.Bar
{
    public partial class BarSidebar
    {
        public BarSidebar(BarSidebarViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
