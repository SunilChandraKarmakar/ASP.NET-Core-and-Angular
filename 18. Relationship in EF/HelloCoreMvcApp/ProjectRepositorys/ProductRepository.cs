using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Db_Context.DatabaseContext;
using Models;

namespace ProjectRepositorys
{
    public class ProductRepository
    {
        private CoreDb _coreDb = new CoreDb();
        
        public List<Product> GetAllProducts()
        {
            return _coreDb.Products.ToList();
        }

        public List<Category> GetAllCategory()
        {
            return _coreDb.Categories.ToList();
        }

        public Product FindProduct(int? Id)
        {
            return _coreDb.Products.Find(Id);
        }

        public bool Create(Product aProduct)
        {
            _coreDb.Products.Add(aProduct);
            return _coreDb.SaveChanges() > 0;
        }

        public bool Edit(Product aProduct)
        {
            _coreDb.Entry(aProduct).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _coreDb.SaveChanges() > 0;
        }

        public bool Delete(Product aProduct)
        {
            _coreDb.Products.Remove(aProduct);
            return _coreDb.SaveChanges() > 0;
        }
    }
}
