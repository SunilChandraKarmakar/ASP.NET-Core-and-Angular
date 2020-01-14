using HelloCoreMvcApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCoreMvcApp.DatabaseContext
{
    public class CoreDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source = DESKTOP-HHA0TOP; 
                                        Initial Catalog = CustomerDb;
                                        Integrated Security = true";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
