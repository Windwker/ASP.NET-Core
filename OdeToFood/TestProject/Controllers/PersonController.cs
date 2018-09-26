using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Controllers
{
    public class PersonController
    {
        public string Salute()
        {
            return "HI from Person Controller";
        }

        public string SayBye()
        {
            return "Bye";
        }
    }
}
