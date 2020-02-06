using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Db_Context.DatabaseContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using ProjectRepositorys;

namespace HelloCoreMvcApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();

        [HttpGet]
        public IActionResult Index()
        {
            return View(_customerRepository.GetAll());
        }

        [HttpGet]
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
                bool isSaved = _customerRepository.Add(aCustomer);

                if(isSaved)
                    return RedirectToAction("Index", "Customer");
                else
                    return ViewBag.ErrorMessage = "Customer not saved!";
            }                      
            else
            {
                ViewBag.AddressList = AddressList();
                return View(aCustomer);
            }                     
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {               
            Customer aCustomer = _customerRepository.GetById(Id);

            if (aCustomer == null)
                return NotFound();

            ViewBag.AddressList = AddressList();
            return View(aCustomer); 
        }

        [HttpPost]
        public IActionResult Edit(Customer aCustomer)
        {
            if(ModelState.IsValid)
            {
                bool isSaved = _customerRepository.Update(aCustomer);

                if (isSaved)
                    return RedirectToAction("Index", "Customer");
                else
                    return ViewBag.ErrorMessage = "Customer is not saved!";
            }

            ViewBag.AddressList = AddressList();
            return View(aCustomer);
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            Customer aCustomer = _customerRepository.GetById(Id);

            if (aCustomer == null)
                return NotFound();

            return View(aCustomer);
        }

        [HttpPost]
        public IActionResult Delete(Customer aCustomer)
        {
            bool isDelete = _customerRepository.Remove(aCustomer);

            if (isDelete)
                return RedirectToAction("Index", "Customer");
            else
                return ViewBag.ErrorMessage = "Coustomer has not deleted!";
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