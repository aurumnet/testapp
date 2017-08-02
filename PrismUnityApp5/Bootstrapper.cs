using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;
using PrismUnityApp5.Views;
using System.Windows;

namespace PrismUnityApp5
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            var catalog = (ModuleCatalog)this.ModuleCatalog;
            catalog.AddModule(typeof(Menu.MenuModule));
            catalog.AddModule(typeof(Menu.ContentModule));
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
