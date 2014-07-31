namespace PoC.PrismTabbedNavigation.Foo
{
    public partial class FooSidebar
    {
        public FooSidebar(FooSidebarViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
