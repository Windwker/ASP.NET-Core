using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevicesManager.Data;
using DevicesManager.Models;

namespace DevicesManager.Services
{
    public class SqlDevicesData : IDevicesData
    {
        private DevicesDbContext _context;

        public SqlDevicesData(DevicesDbContext context)
        {
            _context = context;
        }
        public void AddDevice(Devices device)
        {
            _context.Devices.Add(device);
            _context.SaveChanges();
        }

        public void DeleteDevice(Devices devices)
        {
            _context.Devices.Remove(devices);
            _context.SaveChanges();
        }

        public IEnumerable<Devices> GetAllDevices()
        {
            return _context.Devices.OrderBy(r => r.SerialNumber);
        }

        public Devices GetDeviceBySerialNumber(int serialNumber)
        {
            return _context.Devices.FirstOrDefault(r => r.SerialNumber == serialNumber);
        }

        public void UpdateDevice(Devices devices)
        {
            throw new NotImplementedException();
        }
    }
}
