using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectRepositorys;

namespace HelloCoreMvcApp.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository _productRepository = new ProductRepository();

        [HttpGet]
        public IActionResult Index()
        {
            return View(_productRepository.GetAllProducts());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryList = _productRepository.GetAllCategory();
            return View();
        }
    }
}