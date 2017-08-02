using Microsoft.Practices.Unity;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace PrismUnityApp5.Menu.ViewModels
{
    public class MenuViewModel : BindableBase
    {
        IRegionManager _regionManager;

        private ICommand _sampleCommand;
        public ICommand Sample1Command {
            get {
                return this._sampleCommand ??
                    (this._sampleCommand = new DelegateCommand(Sample1Navigate));
            }
        }

        public void Sample1Navigate()
        {
            _regionManager.RequestNavigate("ContentRegion", "Sample1View");
        }

        public MenuViewModel(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            

        }


    }
}
