using DevicesManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesManager.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Devices> DevicesList { get; set; }
    }
}
