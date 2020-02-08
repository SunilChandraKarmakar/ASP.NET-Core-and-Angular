using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Db_Context.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Models;
using ProjectRepositorys.Base;
using ProjectRepositorys.Contracts;

namespace ProjectRepositorys
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly CoreDb _coreDb;

        public ProductRepository()
        {
            _coreDb = new CoreDb();
        }

        public override ICollection<Product> GetAll()
        {
            return _coreDb.Products
                .Include(p => p.Category)
                .ToList();
        }

        public List<Product> IsActiveProduct()
        {
            List<Product> productList = _coreDb.Products.ToList();

            foreach (Product item in productList)
            {
                _coreDb.Entry(item)
                       .Reference(p => p.Category)
                       .Load();
            }

            return productList;
        }
    }
}
