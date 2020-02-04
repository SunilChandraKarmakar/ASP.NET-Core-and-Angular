using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using ProjectRepositorys;

namespace HelloCoreMvcApp.Controllers
{
    public class CountryController : Controller
    {
        private CountryRepository _countryRepository = new CountryRepository();

        [HttpGet]
        public IActionResult Index()
        {
            return View(_countryRepository.CountryList());
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
                bool isSave = _countryRepository.Create(aCountry);

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

            Country aCountry = _countryRepository.FindCountry(Id);

            if (aCountry == null)
                return NotFound();

            return View(aCountry);
        }

        [HttpPost]
        public IActionResult Edit(Country aCountry)
        {
            if(ModelState.IsValid)
            {
                bool isEdit = _countryRepository.Edit(aCountry);

                if (isEdit)
                    return RedirectToAction("Index", "Country");
                else
                    return ViewBag.ErrorMessage = "Country edit failed!";
            }
            
            return View(aCountry);
        }
    }
}