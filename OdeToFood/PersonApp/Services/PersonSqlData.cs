using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonApp.Data;
using PersonApp.Models;

namespace PersonApp.Services
{
    public class PersonSqlData : IPersonData
    {
        private PersonDbContext _personDbContext;

        public PersonSqlData(PersonDbContext personDbContext)
        {
            _personDbContext = personDbContext;
        }
        public void Add(Person person)
        {
            _personDbContext.People.Add(person);
            _personDbContext.SaveChanges();
            
        }

        public IEnumerable<Person> Get()
        {
            return _personDbContext.People.OrderBy(r => r.Number);
        }

        public Person Get(int number)
        {
            return _personDbContext.People.FirstOrDefault(r => r.Number == number);
        }
    }
}
