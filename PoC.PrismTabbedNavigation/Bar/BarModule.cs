using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace PoC.PrismTabbedNavigation.Bar
{
    public class BarModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public BarModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("SidebarRegion", typeof(BarSidebar));
            _regionManager.RegisterViewWithRegion("MainRegion", typeof (BarView));
        }
    }
}
