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
        private Customer _Customer;
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer aCustomer)
        {
            if (ModelState.IsValid)
            {
                _Customer = aCustomer;
                return RedirectToAction("Details");
            }                      
            else
                return View(aCustomer);
        }

        public IActionResult Details()
        {
            var customerInfo = _Customer;
            return View(customerInfo);
        }
    }
}