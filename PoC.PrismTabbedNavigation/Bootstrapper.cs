using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;

namespace PoC.PrismTabbedNavigation
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            var moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(Foo.FooModule));
            moduleCatalog.AddModule(typeof(Bar.BarModule));
            moduleCatalog.AddModule(typeof(Baz.BazModule));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.RegisterType(typeof (Shell));
            Container.RegisterType(typeof (Foo.FooViewModel));
            Container.RegisterType(typeof (Foo.FooView));
            Container.RegisterType(typeof (Bar.BarView));
            Container.RegisterType(typeof (Baz.BazView));
        }
    }
}
