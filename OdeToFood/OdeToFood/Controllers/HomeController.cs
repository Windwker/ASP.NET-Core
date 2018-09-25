using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController // receive a request to root of the aplication. By default it will be instantiated
    {
        public string Index() // this is the first methot application will look for on the HomeController.cs
        {
            return "Hello from the HomeController";
        }
    }
}
