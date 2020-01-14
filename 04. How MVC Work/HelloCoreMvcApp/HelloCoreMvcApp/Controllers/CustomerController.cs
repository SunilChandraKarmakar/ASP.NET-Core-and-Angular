using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloCoreMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloCoreMvcApp.Controllers
{
    public class CustomerController : Controller
    {
        public string Create(Customer aCustomer)
        {
            return @"Customer created successfully. Name : " + aCustomer.Name + 
                                                    " Address : " + aCustomer.Address;
        }
    }
}