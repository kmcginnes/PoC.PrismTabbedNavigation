using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;

namespace PoC.PrismTabbedNavigation.Bar
{
    public class BarSidebarViewModel : Screen
    {
        public BarSidebarViewModel(IRegionManager regionManager)
        {
            ShowBar = new DelegateCommand(() => regionManager.RequestNavigate("MainRegion", "BarView"));
        }

        public DelegateCommand ShowBar { get; set; }
    }
}
