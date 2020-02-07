using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic_Layer;
using Microsoft.AspNetCore.Mvc;
using Models;
using ProjectRepositorys;

namespace HelloCoreMvcApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductManager _productManager;

        public ProductController()
        {
            _productManager = new ProductManager();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_productManager.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryList = _productManager.CategoryList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product aProduct)
        {
            if(ModelState.IsValid)
            {
                bool isSaved = _productManager.Add(aProduct);

                if (isSaved)
                    return RedirectToAction("Index", "Product");
                else
                    return ViewBag.ErrorMessage = "Product have not saved!";
            }

            ViewBag.CategoryList = _productManager.CategoryList();
            return View(aProduct);
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
                NotFound();

            Product aProduct = _productManager.GetById(Id);

            if (aProduct == null)
                NotFound();

            ViewBag.CategoryList = _productManager.CategoryList();
            return View(aProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product aProduct)
        {
            if(ModelState.IsValid)
            {
                bool isEdit = _productManager.Update(aProduct);

                if (isEdit)
                    return RedirectToAction("Index", "Product");
                else
                    return ViewBag.ErrorMessage = "Product update failed!";
            }

            ViewBag.CategoryList = _productManager.CategoryList();
            return View(aProduct);
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
                NotFound();

            Product aProduct = _productManager.GetById(Id);

            if (aProduct == null)
                NotFound();

            return View(aProduct);
        }

        [HttpPost]
        public IActionResult Delete(Product aProduct)
        {
            bool isDelete = _productManager.Remove(aProduct);

            if (isDelete)
                return RedirectToAction("Index", "Product");
            else
                return ViewBag.MessageError = "Product delete failed!";
        }
    }
}