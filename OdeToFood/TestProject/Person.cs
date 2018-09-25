using Microsoft.Extensions.Configuration;

namespace TestProject
{
    public class Person : IPerson
    {
        private string _configuration;

        public Person(IConfiguration configuration)
        {
            _configuration = configuration["Name"];
        }
        public string SayName()
        {
            return "Name is: "  + _configuration;
        }
    }
}