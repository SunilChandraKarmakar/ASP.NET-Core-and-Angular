using Db_Context.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Models;
using ProjectRepositorys.Base;
using ProjectRepositorys.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectRepositorys
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository 
    {
        
    }
}
