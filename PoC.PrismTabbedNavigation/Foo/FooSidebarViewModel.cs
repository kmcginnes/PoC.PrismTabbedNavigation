using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;

namespace PoC.PrismTabbedNavigation.Foo
{
    public class FooSidebarViewModel : Screen
    {
        public FooSidebarViewModel(IRegionManager regionManager)
        {
            ShowFoo = new DelegateCommand(() => regionManager.RequestNavigate("MainRegion", "FooView"));
        }

        public DelegateCommand ShowFoo { get; set; }
    }
}
