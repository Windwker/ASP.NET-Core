using EmployeeTest.Services;
using EmployeeTest.ViewModels;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeTest.Controllers
{

    public class HomeController : Controller
    {
     
        private IEmployees _employees;
        private IGreeter _greeter;

        public HomeController(IEmployees employees, IGreeter greeter )
        {
            
            _employees = employees;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.employees = _employees.GetAll();
            model.message = _greeter.SayHi();
            return View(model);
        }
    }
}
