using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace PoC.PrismTabbedNavigation.Baz
{
    public class BazModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public BazModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("SidebarRegion", typeof(BazSidebar));
            _regionManager.RegisterViewWithRegion("MainRegion", typeof (BazView));
            _regionManager.RegisterViewWithRegion("NestedRegion", typeof (BazNested1View));
            _regionManager.RegisterViewWithRegion("NestedRegion", typeof (BazNested2View));
        }
    }
}
