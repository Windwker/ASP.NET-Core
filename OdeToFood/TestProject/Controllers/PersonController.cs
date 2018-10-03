using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Models;

namespace TestProject.Controllers
{
    public class PersonController : Controller
    {
        private Person _person;

        public PersonController(Person person)
        {
            _person = person;
        }
    
    public IActionResult Index()
        {
            var model = new Person();
            model.IdNumber = 1;
            model.Name = "Javier";

            return View(model);
        }



    public IActionResult Create(Person person)
        {
            _person.IdNumber = person.IdNumber;
            return View("Index");
        }

    }


}
