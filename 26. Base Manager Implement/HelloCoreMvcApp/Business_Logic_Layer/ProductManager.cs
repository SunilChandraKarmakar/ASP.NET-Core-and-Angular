using Business_Logic_Layer.BLL;
using Models;
using ProjectRepositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer
{
    public class ProductManager : Manager<Product>
    {
        private readonly ProductRepository _productRepository;

        public ProductManager() : base(new ProductRepository())
        {
            _productRepository = new ProductRepository();
        }

        public List<Category> CategoryList()
        {
            return _productRepository.CategoryList();
        }
    }
}
