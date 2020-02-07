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
    public class CountryController : Controller
    {
        private readonly CountryManager _countryManager;
        
        public CountryController()
        {
            _countryManager = new CountryManager();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_countryManager.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country aCountry)
        {
            if(ModelState.IsValid)
            {
                bool isSave = _countryManager.Add(aCountry);

                if (isSave)
                    return RedirectToAction("Index", "Country");
                else
                    return ViewBag.ErrorMessage = "Country saved failed!";
            }

            return View(aCountry);
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
                return NotFound();

            Country aCountry = _countryManager.GetById(Id);

            if (aCountry == null)
                return NotFound();

            return View(aCountry);
        }

        [HttpPost]
        public IActionResult Edit(Country aCountry)
        {
            if(ModelState.IsValid)
            {
                bool isEdit = _countryManager.Update(aCountry);

                if (isEdit)
                    return RedirectToAction("Index", "Country");
                else
                    return ViewBag.ErrorMessage = "Country edit failed!";
            }
            
            return View(aCountry);
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
                return NotFound();

            Country aCountry = _countryManager.GetById(Id);

            if (aCountry == null)
                return NotFound();

            return View(aCountry);
        }

        [HttpPost]
        public IActionResult Delete(Country aCountry)
        {
            bool isDelete = _countryManager.Remove(aCountry);

            if (isDelete)
                return RedirectToAction("Index", "Country");
            else
                return ViewBag.ErrorMessage = "Country failed to delete!";
        }
    }
}