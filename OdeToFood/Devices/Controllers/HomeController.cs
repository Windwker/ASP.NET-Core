using DevicesManager.Models;
using DevicesManager.Services;
using DevicesManager.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DevicesManager.Controllers
{
    public class HomeController : Controller
    {
        private IDevicesData _devicesData;

        public HomeController(IDevicesData devicesData)
        {
            _devicesData = devicesData;
        }


        public ActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.DevicesList = _devicesData.GetAllDevices();
            return View(model);
        }


        public ActionResult Details(int serialNumber)
        {
            var model = new HomeDetailsViewModel();
             model.DeviceById = _devicesData.GetDeviceBySerialNumber(serialNumber);
            return View(model);

        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Devices device)
        {
            if (ModelState.IsValid)
            {
                _devicesData.AddDevice(device);

                return RedirectToAction(nameof(Details), new { serialNumber = device.SerialNumber });
            }
            else
            {
                return View();
            }

        }public ActionResult Delete(Devices device)
        {

            _devicesData.DeleteDevice(device);
            return RedirectToAction(nameof(Index));

        }

    }
}
