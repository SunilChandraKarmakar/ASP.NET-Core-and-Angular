using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic_Layer;
using Business_Logic_Layer.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using ProjectRepositorys;

namespace HelloCoreMvcApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductManager _iProductManager;
        private readonly ICategoryManager _iCategoryManager;

        public ProductController(IProductManager iProductManager, ICategoryManager iCategoryManager)
        {
            _iProductManager = iProductManager;
            _iCategoryManager = iCategoryManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_iProductManager.GetAll());
        }

        private List<SelectListItem> CategoryList()
        {
            List<SelectListItem> categoryList = _iCategoryManager.GetAll()
                                                .Select(c=>new SelectListItem() { 
                                                Value = c.Id.ToString(),
                                                Text = c.Name
                                            }).ToList();
            return categoryList;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryList = CategoryList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product aProduct)
        {
            if(ModelState.IsValid)
            {
                bool isSaved = _iProductManager.Add(aProduct);

                if (isSaved)
                    return RedirectToAction("Index", "Product");
                else
                    return ViewBag.ErrorMessage = "Product have not saved!";
            }

            ViewBag.CategoryList = CategoryList();
            return View(aProduct);
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
                NotFound();

            Product aProduct = _iProductManager.GetById(Id);

            if (aProduct == null)
                NotFound();

            ViewBag.CategoryList = CategoryList();
            return View(aProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product aProduct)
        {
            if(ModelState.IsValid)
            {
                bool isEdit = _iProductManager.Update(aProduct);

                if (isEdit)
                    return RedirectToAction("Index", "Product");
                else
                    return ViewBag.ErrorMessage = "Product update failed!";
            }

            ViewBag.CategoryList = CategoryList();
            return View(aProduct);
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
                NotFound();

            Product aProduct = _iProductManager.GetById(Id);

            if (aProduct == null)
                NotFound();

            return View(aProduct);
        }

        [HttpPost]
        public IActionResult Delete(Product aProduct)
        {
            bool isDelete = _iProductManager.Remove(aProduct);

            if (isDelete)
                return RedirectToAction("Index", "Product");
            else
                return ViewBag.MessageError = "Product delete failed!";
        }
    }
}