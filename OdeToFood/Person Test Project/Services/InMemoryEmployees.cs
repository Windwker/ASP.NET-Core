using EmployeeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTest.Services
{
    public class InMemoryEmployees : IEmployees
    {
        List<Employee> employees = new List<Employee>();

        public InMemoryEmployees()
        {
            employees.Add(new Employee { Id = 1, Name = "Javi" });
            employees.Add(new Employee { Id = 2, Name = "Juan" });
            employees.Add(new Employee { Id = 3, Name = "Pedro" });
            employees.Add(new Employee { Id = 4, Name = "Enrique" });
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees.OrderBy(r=> r.Id);
        }
    }
}
