using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismUnityApp5.Menu.ViewModels
{
    public class Sample1ContentBViewModel : BindableBase,INavigationAware
    {
        private string _contentText;
        public string ContentText
        {
            get { return _contentText; }
            set { SetProperty(ref _contentText, value); }
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            ContentText = navigationContext.Parameters["SampleText"] as string;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }
        public Sample1ContentBViewModel()
        {
            ContentText = "TestB";
        }
    }
}
