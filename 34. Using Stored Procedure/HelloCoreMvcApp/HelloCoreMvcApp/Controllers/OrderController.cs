using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business_Logic_Layer.Contracts;
using HelloCoreMvcApp.Models.ProductModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using Models.ViewModel;

namespace HelloCoreMvcApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderManager _iOrderManager;
        private readonly ICoustomerManager _iCoustomerManager;
        private readonly IProductManager _iProductManager;
        private readonly IMapper _iMapper; 
        
        public OrderController(IOrderManager iOrderManager, 
                                ICoustomerManager iCoustomerManager, 
                                IProductManager iProductManager, IMapper iMapper)
        {
            _iOrderManager = iOrderManager;
            _iCoustomerManager = iCoustomerManager;
            _iProductManager = iProductManager;
            _iMapper = iMapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<OrderInfoView> orderInfoView = _iOrderManager.OrderInfoView();
            return View(orderInfoView);
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

        private OrderViewModel PassOrderViewData()
        {
            OrderViewModel orderViewModel = new OrderViewModel();
            orderViewModel.CustomerList = CustomerList();
            orderViewModel.ProductList = ProductList();
            return orderViewModel;
        }

        [HttpGet]
        public IActionResult Create()
        {             
            return View(PassOrderViewData());
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel orderViewModel)
        {
            if(ModelState.IsValid)
            {
                Order aOrder = _iMapper.Map<Order>(orderViewModel);
                bool isSave = _iOrderManager.Add(aOrder);

                if (isSave)
                    return RedirectToAction("Create", "Order");
                else
                    return ViewBag.ErrorMessage = "Order saved failed!";
            }  
            
            return View(PassOrderViewData());
        }

        [HttpGet]
        public IActionResult OrderViewModelSP(string cName, string oNo)
        {
            ICollection<OrderViewModelSP> orderViewModelSPs = _iOrderManager.OrderViewModelSPs(cName, oNo);
            return View(orderViewModelSPs);
        }
    }
}