using Business_Logic_Layer.BLL;
using Business_Logic_Layer.Contracts;
using Models;
using ProjectRepositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer
{
    public class ProductManager : Manager<Product>, IProductManager
    {
        private readonly ProductRepository _productRepository;

        public ProductManager() : base(new ProductRepository())
        {
            _productRepository = new ProductRepository();
        }

        public ICollection<Category> CategoryList()
        {
            return _productRepository.CategoryList();
        }

        public ICollection<Product> GetByYear(int year)
        {
            throw new NotImplementedException();
        }
    }
}
