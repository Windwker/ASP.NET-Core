﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonApp.Models;
using PersonApp.Services;
using PersonApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonApp.Controllers
{
    public class HomeController : Controller
    {
        private IPersonData _personData;

        public HomeController(IPersonData personData)
        {
            _personData = personData;
        }
        public IActionResult Index()
        {

            var model = new HomeIndexViewModel();
            model.People = _personData.Get();
            return View(model);
        }

        public IActionResult Details(int number)
        {
            var model = new HomeDetailsViewModel();
            model.Person = _personData.Get().FirstOrDefault(r=> r.Number == number);
            
            return View(model.Person);
            
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Person person)
        {
            if (ModelState.IsValid)
            {
                Person newPerson = new Person();
                newPerson.Name = person.Name;
                newPerson.Number = person.Number;
                _personData.Add(newPerson);

                //return View("Details", newPerson);

                return RedirectToAction(nameof(Details), new { number = newPerson.Number });
            }
            else
            {

                return View();
            }
        


        }


    }
}
