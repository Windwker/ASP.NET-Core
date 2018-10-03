using PersonApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApp.Services
{
    public class PersonMemoryData: IPersonData
    {
        public List<Person> People = new List<Person>();

        public PersonMemoryData()
        {
            People.Add(new Person { Id = 1, Name = "Javi" });
            People.Add(new Person { Id = 2, Name = "Juan" });
            People.Add(new Person { Id = 3, Name = "Pedro" });
            People.Add(new Person { Id = 4, Name = "Carlos" });
        }

        public void Add(Person person)
        {
            People.Add(person);
        }

        public IEnumerable<Person> Get()
        {
            return People.OrderBy(r => r.Id);
        }
    }
}
