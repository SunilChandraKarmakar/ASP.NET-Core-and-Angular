using Business_Logic_Layer.BLL;
using Models;
using ProjectRepositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer
{
    public class CustomerManager : Manager<Customer>
    {
        public CustomerManager() : base(new CustomerRepository())
        {

        }
    }
}
