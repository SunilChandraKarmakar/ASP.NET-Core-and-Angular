using Business_Logic_Layer.BLL;
using Business_Logic_Layer.Contracts;
using Models;
using ProjectRepositorys;
using ProjectRepositorys.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer
{
    public class ProductManager : Manager<Product>, IProductManager
    {
        private readonly IProductRepository _iProductRepository;

        public ProductManager(IProductRepository iProductRepository) : base(iProductRepository)
        {
            _iProductRepository = iProductRepository;
        }

        public ICollection<Product> GetByYear(int year)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return _iProductRepository.GetProductByCategoryId(categoryId);
        }
    }
}
