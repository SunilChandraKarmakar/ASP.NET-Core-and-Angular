using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using ProjectRepositorys;

namespace HelloCoreMvcApp.Controllers
{
    public class CityController : Controller
    {
        private CityRepository _cityRepository = new CityRepository();

        [HttpGet]
        public IActionResult Index()
        {
            return View(_cityRepository.Cities());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CountryList = _cityRepository.countries();
            return View();
        }

        [HttpPost]
        public IActionResult Create(City aCity)
        {
            if(ModelState.IsValid)
            {
                bool isSave = _cityRepository.Add(aCity);

                if (isSave)
                    return RedirectToAction("Index", "City");
                else
                    return ViewBag.ErrorMessage = "City failed to save!";
            }

            ViewBag.CountryList = _cityRepository.countries();
            return View(aCity);
        }
    }
}