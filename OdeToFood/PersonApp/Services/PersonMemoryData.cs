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
            People.Add(new Person { Number = 1, Name = "Javi" });
            People.Add(new Person { Number = 2, Name = "Juan" });
            People.Add(new Person { Number = 3, Name = "Pedro" });
            People.Add(new Person { Number = 4, Name = "Carlos" });
        }

        public void Add(Person person)
        {
            People.Add(person);
        }

        public IEnumerable<Person> Get()
        {
            return People.OrderBy(r => r.Number);
        }

        public Person Get(int number)
        {
            return People.FirstOrDefault(r => r.Number == number);
        }
    }
}
