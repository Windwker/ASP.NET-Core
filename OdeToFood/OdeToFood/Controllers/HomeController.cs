using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller // receive a request to root of the aplication. By default it will be instantiated
    {
        private IRestaurantData _restaurant;

        public HomeController(IRestaurantData restaurant)
        {
            _restaurant = restaurant;
        }

        public IActionResult Index() // this is the first methot application will look for on the HomeController.cs
        {
            var model = _restaurant.GetAll();
            //return new ObjectResult(model); // Controller returns the ObjectResult to the pipeline.



            return View(model);
        }
    }
}
