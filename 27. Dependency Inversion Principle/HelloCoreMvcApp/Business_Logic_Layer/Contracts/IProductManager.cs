using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer.Contracts
{
    public interface IProductManager
    {
        Product GetById(int? id);

        ICollection<Product> GetAll();

        bool Add(Product aProduct);

        bool Update(Product aProduct);

        bool Remove(Product aProduct);

        ICollection<Category> CategoryList();

        ICollection<Product> GetByYear(int year);
    }
}
