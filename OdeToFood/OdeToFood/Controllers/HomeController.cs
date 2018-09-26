using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller // receive a request to root of the aplication. By default it will be instantiated
    {
        private IRestaurantData _restaurant;
        private IGreeter _greeter;

        public HomeController(IRestaurantData restaurant, IGreeter greeter)
        {
            _restaurant = restaurant;
            _greeter = greeter;
        }

        public IActionResult Index() // this is the first methot application will look for on the HomeController.cs
        {
            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurant.GetAll();
            model.Message = _greeter.GetMessageOfTheDay();
            //return new ObjectResult(model); // Controller returns the ObjectResult to the pipeline.



            return View(model);
        }
    }
}
