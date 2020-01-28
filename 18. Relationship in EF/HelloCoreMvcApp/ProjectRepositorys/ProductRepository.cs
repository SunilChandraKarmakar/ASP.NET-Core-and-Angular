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
    }
}
