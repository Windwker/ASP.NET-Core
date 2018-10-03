using PersonApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApp.Services
{
    public interface IPersonData
    {
        IEnumerable<Person> Get();
        void Add(Person person);
    }
}
