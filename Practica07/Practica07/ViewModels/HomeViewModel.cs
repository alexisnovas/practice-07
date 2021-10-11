using Practica07.Service;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Practica07.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            OrientationCommand = new DelegateCommand(GetOrientation);
        }

        private void GetOrientation()
        {
            DeviceOrientation DeviceOrientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
            DeviceOrientationName = DeviceOrientation.IsPortrait() ? "Portrait" : "Landscape";
        }

        public override string Title => "Home";
        public ICommand OrientationCommand { get; }
        public string DeviceOrientationName { get;  set; }
    }
}
