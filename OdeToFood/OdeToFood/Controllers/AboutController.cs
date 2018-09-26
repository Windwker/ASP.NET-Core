using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    //[Route("[controller]/[action]")]  Atribute Routing.
    public class AboutController : Controller
    {
        public string Phone()
        {
            return "155152220";
        }

        public IActionResult Address() // Returns a content that derives from base class controller. 
        {
            return Content("Fruta");
        }

     

    }
}
