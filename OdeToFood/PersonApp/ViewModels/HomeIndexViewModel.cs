using PersonApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApp.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Person> People { get; set; }
    }
}
