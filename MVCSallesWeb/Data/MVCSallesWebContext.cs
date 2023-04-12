using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCSallesWeb.Models;

namespace MVCSallesWeb.Data
{
    public class MVCSallesWebContext : DbContext
    {
        public MVCSallesWebContext (DbContextOptions<MVCSallesWebContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
