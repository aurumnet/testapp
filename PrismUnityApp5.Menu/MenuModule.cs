using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using PrismUnityApp5.Menu.Views;
using System;

namespace PrismUnityApp5.Menu
{
    public class MenuModule : IModule
    {
        
        IRegionManager _regionManager;
        IUnityContainer _container;

        public MenuModule(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MenuRegion", typeof(MenuView));
        }
    }
}