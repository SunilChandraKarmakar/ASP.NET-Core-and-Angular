using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic_Layer;
using Business_Logic_Layer.Contracts;
using Microsoft.AspNetCore.Mvc;
using Models;
using ProjectRepositorys;

namespace HelloCoreMvcApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryManager _iCategoryManager;

        public CategoryController(ICategoryManager iCategoryManager)
        {
            _iCategoryManager = iCategoryManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var CategoryList = _iCategoryManager.GetAll();
            return View(CategoryList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category aCategory)
        {
            if(ModelState.IsValid)
            {
                bool isSaved = _iCategoryManager.Add(aCategory);

                if (isSaved)
                    return RedirectToAction("Index", "Category");
                else
                    return ViewBag.ErrorMessage = "Category have not saved!";
            }

            return View(aCategory);
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
                return NotFound();

            Category aCategory = _iCategoryManager.GetById(Id);

            if (aCategory == null)
                return NotFound();

            return View(aCategory);
        }

        [HttpPost]
        public IActionResult Edit(Category aCategory)
        {
            if(ModelState.IsValid)
            {
                bool isUpdate = _iCategoryManager.Update(aCategory);

                if (isUpdate)
                    return RedirectToAction("Index", "Category");
                else
                    return ViewBag.ErrorMessage = "Category Not Update!";
            }

            return View(aCategory);
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
                NotFound();

            Category aCategory = _iCategoryManager.GetById(Id);

            if (aCategory == null)
                NotFound();

            return View(aCategory);
        }

        [HttpPost]
        public IActionResult Delete(Category aCategory)
        {            
            bool isDelete = _iCategoryManager.Remove(aCategory);

            if (isDelete)
                return RedirectToAction("Index", "Category");
            else
                return ViewBag.ErrorMessage = "Category Delete Failed!";
        }
    }
}