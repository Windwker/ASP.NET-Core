using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace TestProject
{
    public class Person : Controller
    {
        private string _configuration;

        public Person(IConfiguration configuration)
        {
            _configuration = configuration["Name"];
        }
        public IActionResult SayName()
        {
            return Content("Name is: "  + _configuration);
        }
    }
}