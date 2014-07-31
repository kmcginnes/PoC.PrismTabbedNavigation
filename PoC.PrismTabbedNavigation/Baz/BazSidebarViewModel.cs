using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;

namespace PoC.PrismTabbedNavigation.Baz
{
    public class BazSidebarViewModel : Screen
    {
        public BazSidebarViewModel(IRegionManager regionManager)
        {
            ShowBaz = new DelegateCommand(() => regionManager.RequestNavigate("MainRegion", "BazView"));
        }

        public DelegateCommand ShowBaz { get; set; }
    }
}
