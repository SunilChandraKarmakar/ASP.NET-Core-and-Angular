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
        public IActionResult Create(Customer aCustomer)
        {
            return View();
        }
    }
}