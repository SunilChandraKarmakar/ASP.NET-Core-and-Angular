using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    }
}