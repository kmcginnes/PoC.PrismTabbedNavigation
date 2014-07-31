using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace PoC.PrismTabbedNavigation.Foo
{
    public class FooModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public FooModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("SidebarRegion", typeof(Foo.FooSidebar));
            _regionManager.RegisterViewWithRegion("MainRegion", typeof (Foo.FooView));
        }
    }
}
