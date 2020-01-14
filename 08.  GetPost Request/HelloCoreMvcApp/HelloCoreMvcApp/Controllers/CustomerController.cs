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
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer aCustomer)
        {
            if (ModelState.IsValid)
            {
                //Database code hare
                return RedirectToAction("Details", aCustomer);
            }                      
            else
                return View(aCustomer);
        }

        public IActionResult Details(Customer aCustomer)
        {
            return View(aCustomer);
        }
    }
}