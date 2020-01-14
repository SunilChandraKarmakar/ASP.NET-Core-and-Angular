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
            if (ModelState.IsValid)
                return @"Customer created successfully. Name : " + aCustomer.Name +
                                                    " Address : " + aCustomer.Address;
            else
                return "Model Binding Error!";
        }
    }
}