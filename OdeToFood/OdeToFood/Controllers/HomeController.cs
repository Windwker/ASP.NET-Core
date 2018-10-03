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


        public IActionResult Details(int id)
        {
            var model = new HomeDetailsViewModel();
            model.Restaurant = _restaurant.Get(id);
            if (model.Restaurant == null)
            {
                return NotFound();
            }
            else
            {
                return View(model.Restaurant);
            }

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditViewModel restaurantEditViewModel)
        {
            var newRestaurant = new Restaurant();
            newRestaurant.Name = restaurantEditViewModel.Name;
            newRestaurant.Cuisine = restaurantEditViewModel.Cuisine;
            newRestaurant =_restaurant.Add(newRestaurant);
            return RedirectToAction(nameof(Details), new { id = newRestaurant.Id });
        }
    }
}
