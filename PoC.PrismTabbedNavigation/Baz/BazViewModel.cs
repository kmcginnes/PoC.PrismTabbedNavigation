using System;
using System.Linq;
using System.Windows;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;

namespace PoC.PrismTabbedNavigation.Baz
{
    public class BazViewModel : Screen
    {
        public BazViewModel()
        {
            Switch = new DelegateCommand(() =>
            {
                var region = ServiceLocator.Current.GetInstance<IRegionManager>().Regions["NestedRegion"];
                var otherView = region.Views.First(x => !region.ActiveViews.Contains(x));
                region.Activate(otherView);
            });
        }

        public DelegateCommand Switch { get; set; }

        public override bool ConfirmDeactivation()
        {
            var result = MessageBox.Show("Confirm navigation?", "Confirmation", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            return result != MessageBoxResult.Cancel;
        }
    }
}
