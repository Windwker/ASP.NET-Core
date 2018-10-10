using DevicesManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesManager.Data
{
    public class DevicesDbContext : DbContext
    {
        public DevicesDbContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<Devices> Devices { get; set; }
    }
}
