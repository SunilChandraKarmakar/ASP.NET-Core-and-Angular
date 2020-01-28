using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
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

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
                NotFound();

            Product aProduct = _productRepository.FindProduct(Id);

            if (aProduct == null)
                NotFound();

            ViewBag.CategoryList = _productRepository.GetAllCategory();
            return View(aProduct);
        }
    }
}