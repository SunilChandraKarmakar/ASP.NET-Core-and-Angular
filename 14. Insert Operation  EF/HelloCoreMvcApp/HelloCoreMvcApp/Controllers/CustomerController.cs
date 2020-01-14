using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Db_Context.DatabaseContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;

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
                CoreDb db = new CoreDb();
                db.Customers.Add(aCustomer);
                bool isSaved = db.SaveChanges() > 0;

                if(isSaved)
                    return RedirectToAction("Details", aCustomer);
                else
                    return ViewBag.ErrorMessage = "Customer not saved!";
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