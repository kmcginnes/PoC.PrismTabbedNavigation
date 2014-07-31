namespace PoC.PrismTabbedNavigation.Foo
{
    public partial class FooView
    {
        public FooView(FooViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
