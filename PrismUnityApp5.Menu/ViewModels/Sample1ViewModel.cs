using Microsoft.Practices.Unity;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismUnityApp5.Menu.ViewModels
{
    public class Sample1ViewModel : BindableBase,INavigationAware
    {
        IRegionManager _regionManager;


        public Sample1ViewModel(RegionManager regionManager)
        {
            _regionManager = regionManager;

        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            NavigationParameters paramA = new NavigationParameters();
            NavigationParameters paramB = new NavigationParameters();
            NavigationParameters paramC = new NavigationParameters();
            paramA.Add("SampleText", "TestA");
            _regionManager.RequestNavigate("sample1", "Sample1ContentAView", paramA);
            paramB.Add("SampleText", "TestB");
            _regionManager.RequestNavigate("sample1", "Sample1ContentBView", paramB);
            paramC.Add("SampleText", "TestC");
            _regionManager.RequestNavigate("sample1", "Sample1ContentAView", paramC);

        }
    }
}
