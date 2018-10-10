using DevicesManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesManager.Services
{
    public interface IDevicesData
    {
        Devices GetDeviceBySerialNumber(int serialNumber);
       IEnumerable<Devices> GetAllDevices();
        void AddDevice(Devices device);
        void UpdateDevice(Devices device);
        void DeleteDevice(Devices device);
    }
}
