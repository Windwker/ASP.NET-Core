using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OdeToFood.Pages
{
    public class GreetingsModel : PageModel
    {
        public GreetingsModel(IGreeter greeter)
        {

            _greeter = greeter;
            
        }


        private IGreeter _greeter;
        public string CurrentGreeter { get; set; }
        public void OnGet(string name)
        {
            CurrentGreeter = name + _greeter.GetMessageOfTheDay();
        }
    }
}