using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevicesManager.Models;

namespace DevicesManager.Services
{
    public class InMemoryDevicesData : IDevicesData
    {
        public List<Devices> devicesList = new List<Devices>();
        public InMemoryDevicesData()
        {
            devicesList.Add(new Devices { SerialNumber = 123, DeviceName = "DS9x" ,Description = "Telephone device", InUse= true });
            devicesList.Add(new Devices { SerialNumber = 456, DeviceName = "Plantronics Headset" ,Description = "Headset device",InUse= false });
            
        }

 
        public IEnumerable<Devices> GetAllDevices()
        {
            return devicesList.OrderBy(r => r.SerialNumber);
        }

        public Devices GetDeviceBySerialNumber(int serialNumber)
        {
            return devicesList.FirstOrDefault(r => r.SerialNumber == serialNumber);
        }

        public void UpdateDevice(Devices device)
        {
            throw new NotImplementedException();
        }



        public void AddDevice(Devices device)
        {
            devicesList.Add(device);
        }

        public void DeleteDevice(Devices device)
        {
            throw new NotImplementedException();
        }



    }
}
