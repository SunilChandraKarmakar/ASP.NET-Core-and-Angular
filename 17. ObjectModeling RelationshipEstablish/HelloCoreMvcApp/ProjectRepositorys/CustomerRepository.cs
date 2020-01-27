using Db_Context.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectRepositorys
{
    public class CustomerRepository
    {
        private CoreDb _db = new CoreDb(); 

        public List<Customer> GetAllCustomer()
        {
            return _db.Customers.ToList(); 
        }

        public bool Create(Customer aCustomer)
        {
            _db.Customers.Add(aCustomer);
            return _db.SaveChanges() > 0;
        }

        public Customer FindCustomer(int? Id)
        {
            return _db.Customers.Find(Id);
        }

        public bool Edit(Customer aCustomer)
        {
            _db.Entry(aCustomer).State = EntityState.Modified;
            return _db.SaveChanges() > 0;
        }

        public bool Delete(Customer aCustomer)
        {
            _db.Customers.Remove(aCustomer);
            return _db.SaveChanges() > 0;
        }
    }
}
