using Db_Context.DatabaseContext;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRepositorys.Contracts
{
    public interface IProductRepository : IRepository<Product>
    {
        public List<Product> GetProductByCategoryId(int categoryId);
    }
}
