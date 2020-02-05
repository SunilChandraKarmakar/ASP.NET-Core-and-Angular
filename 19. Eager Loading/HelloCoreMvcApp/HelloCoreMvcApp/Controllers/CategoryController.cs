using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using ProjectRepositorys;

namespace HelloCoreMvcApp.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryRepository _categoryRepository = new CategoryRepository(); 

        [HttpGet]
        public IActionResult Index()
        {
            var CategoryList = _categoryRepository.CategoryList();
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
                bool isSaved = _categoryRepository.Create(aCategory);

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

            Category aCategory = _categoryRepository.FindCategory(Id);

            if (aCategory == null)
                return NotFound();

            return View(aCategory);
        }

        [HttpPost]
        public IActionResult Edit(Category aCategory)
        {
            if(ModelState.IsValid)
            {
                bool isUpdate = _categoryRepository.Edit(aCategory);

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

            Category aCategory = _categoryRepository.FindCategory(Id);

            if (aCategory == null)
                NotFound();

            return View(aCategory);
        }

        [HttpPost]
        public IActionResult Delete(Category aCategory)
        {            
            bool isDelete = _categoryRepository.Delete(aCategory);

            if (isDelete)
                return RedirectToAction("Index", "Category");
            else
                return ViewBag.ErrorMessage = "Category Delete Failed!";
        }
    }
}