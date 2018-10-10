using Microsoft.EntityFrameworkCore;
using PersonApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApp.Data
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
