using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismUnityApp5.Menu.ViewModels
{
    public class Sample1ContentAViewModel : BindableBase,INavigationAware
    {
        private string _contentText;
        public string ContentText
        {
            get { return _contentText; }
            set { SetProperty(ref _contentText, value); }
        }
        public Sample1ContentAViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            ContentText = navigationContext.Parameters["SampleText"].ToString();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }
    }
}
