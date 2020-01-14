using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloCoreMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelloCoreMvcApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Create()
        {
            ViewBag.AddressList = AddressList();
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
            {
                ViewBag.AddressList = AddressList();
                return View(aCustomer);
            }
                
        }

        public IActionResult Details(Customer aCustomer)
        {
            ViewBag.Customer = aCustomer;
            return View();
        }

        public List<SelectListItem> AddressList()
        {
            List<SelectListItem> address = new List<SelectListItem>()
            {
                new SelectListItem { Value = "DHK", Text = "Dhaka"},
                new SelectListItem { Value = "CTG", Text = "Chittagong"},
                new SelectListItem { Value = "Lax", Text = "Lakshmipur"},
            };

            return address;
        }
    }
}