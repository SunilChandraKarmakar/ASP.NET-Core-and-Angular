using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Db_Context.DatabaseContext
{
    public class CoreDb : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; } 
        [Obsolete]
        public DbQuery<OrderInfoView> OrderInfoViews { get; set; }

        [Obsolete]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasIndex(c => c.ContactNo).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Code).IsUnique();
            modelBuilder.Entity<Product>().HasIndex(p => p.Name).IsUnique();
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<City>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Order>().HasIndex(o => o.OrderNo).IsUnique();

            modelBuilder.Query<OrderInfoView>().ToView("OrderInfoView");
            modelBuilder.Query<OrderViewModelSP>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source = DESKTOP-HHA0TOP; 
                                    Initial Catalog = CustomerDb; 
                                    Integrated Security = true";
            optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseLazyLoadingProxies();
        }

        [Obsolete]
        public ICollection<OrderViewModelSP> OrderViewModelSPs(String cName, string oNo)
        {
            SqlParameter customerName = new SqlParameter();
            customerName.ParameterName = "CustomerName";
            customerName.DbType = System.Data.DbType.String;
            customerName.Value = cName ?? (object) DBNull.Value;

            SqlParameter orderNo = new SqlParameter();
            orderNo.ParameterName = "OrderNo";
            orderNo.DbType = System.Data.DbType.String;
            orderNo.Value = oNo ?? (object) DBNull.Value;

            return this.Query<OrderViewModelSP>().FromSql("SP_OrderInfoView @CustomerName, @OrderNo", customerName, orderNo).ToList();
        }
    }
}
