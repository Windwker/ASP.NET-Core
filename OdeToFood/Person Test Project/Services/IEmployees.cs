using EmployeeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTest.Services
{
    public interface IEmployees
    {
        IEnumerable<Employee> GetAll();
    }
}
