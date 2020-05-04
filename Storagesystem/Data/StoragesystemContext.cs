using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storagesystem.Models;

namespace Storagesystem.Data
{
    public class StoragesystemContext : DbContext
    {
        public StoragesystemContext (DbContextOptions<StoragesystemContext> options)
            : base(options)
        {
        }


        public DbSet<Product> Product { get; set; }
    }
}
