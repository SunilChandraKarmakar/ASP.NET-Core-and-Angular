using Business_Logic_Layer.BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer.Contracts
{
    public interface IProductManager : IManager<Product>
    {  
        ICollection<Product> GetByYear(int year); 
        List<Product> GetProductByCategoryId(int categoryId);
    }
}
