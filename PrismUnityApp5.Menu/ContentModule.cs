using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using PrismUnityApp5.Menu.Views;
using System;

namespace PrismUnityApp5.Menu
{
    public class ContentModule : IModule
    {
        
        IRegionManager _regionManager;
        IUnityContainer _container;

        public ContentModule(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void Initialize()
        {
            _container.RegisterType<object, Sample1View>("Sample1View");
            _container.RegisterType<object, Sample1ContentAView>("Sample1ContentAView");
            _container.RegisterType<object, Sample1ContentBView>("Sample1ContentBView");
        }
    }
}