using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Practica07.Service
{
    public interface IDeviceOrientationService
    {
       DeviceOrientation GetOrientation();
    }
}
