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
    public class CustomerManager : Manager<Customer>, ICoustomerManager  
    {
        private readonly ICustomerRepository _iCustomeRepository;
        public CustomerManager(ICustomerRepository iCustomerRepository) : base(iCustomerRepository)
        {
            _iCustomeRepository = iCustomerRepository;
        }
    }
}
