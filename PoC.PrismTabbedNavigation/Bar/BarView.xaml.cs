namespace PoC.PrismTabbedNavigation.Bar
{
    public partial class BarView
    {
        public BarView(BarViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
