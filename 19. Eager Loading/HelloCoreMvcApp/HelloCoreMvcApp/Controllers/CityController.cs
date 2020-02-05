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
        private readonly CityRepository _cityRepository;

        public CityController()
        {
            _cityRepository = new CityRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_cityRepository.Cities());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CountryList = _cityRepository.Countries();
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

            ViewBag.CountryList = _cityRepository.Countries();
            return View(aCity);
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
                return NotFound();

            City aCity = _cityRepository.FindCity(Id);

            if (aCity == null)
                return NotFound();

            ViewBag.CountryList = _cityRepository.Countries();
            return View(aCity);
        }

        [HttpPost]
        public IActionResult Edit(City aCity)
        {
            if(ModelState.IsValid)
            {
                bool isUpdate = _cityRepository.Edit(aCity);

                if (isUpdate)
                    return RedirectToAction("Index", "City");
                else
                    return ViewBag.ErrorMessage = "City update failed!";
            }

            List<Country> CountryList = ViewBag.CountryList;
            return View(aCity);
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
                return NotFound();

            City aCity = _cityRepository.FindCity(Id);

            if (aCity == null)
                return NotFound();

            return View(aCity);
        }

        [HttpPost]
        public IActionResult Delete(City aCity)
        {
            bool isDelete = _cityRepository.Delete(aCity);

            if (isDelete)
                return RedirectToAction("Index", "City");
            else
                return ViewBag.Error = "City delete is failed!";
        }
    }
}