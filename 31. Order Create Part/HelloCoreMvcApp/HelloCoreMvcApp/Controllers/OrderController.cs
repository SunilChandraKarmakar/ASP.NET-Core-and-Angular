using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic_Layer.Contracts;
using HelloCoreMvcApp.Models.ProductModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelloCoreMvcApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderManager _iOrderManager;
        private readonly ICoustomerManager _iCoustomerManager;
        private readonly IProductManager _iProductManager;
        
        public OrderController(IOrderManager iOrderManager, 
                                ICoustomerManager iCoustomerManager, IProductManager iProductManager)
        {
            _iOrderManager = iOrderManager;
            _iCoustomerManager = iCoustomerManager;
            _iProductManager = iProductManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        private List<SelectListItem> CustomerList()
        {
            List<SelectListItem> customerList = _iCoustomerManager.GetAll().Select(c => new SelectListItem() { 
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
            return customerList;
        }

        private List<SelectListItem> ProductList()
        {
            List<SelectListItem> productList = _iProductManager.GetAll().Select(p => new SelectListItem() { 
                Value = p.Id.ToString(),
                Text = p.Name
            }).ToList();
            return productList;
        }

        [HttpGet]
        public IActionResult Create()
        {
            OrderViewModel orderViewModel = new OrderViewModel();
            orderViewModel.CustomerList = CustomerList();
            orderViewModel.ProductList = ProductList();
            return View(orderViewModel);
        }
    }
}