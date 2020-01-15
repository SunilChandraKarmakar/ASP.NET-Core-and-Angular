using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db_Context.DatabaseContext
{
    public class CoreDb : DbContext
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
