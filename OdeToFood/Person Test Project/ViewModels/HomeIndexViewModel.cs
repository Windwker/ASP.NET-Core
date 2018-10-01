using EmployeeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTest.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Employee> employees;
        public string message;
    }
}
