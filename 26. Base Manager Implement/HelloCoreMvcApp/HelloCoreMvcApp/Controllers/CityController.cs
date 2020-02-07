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
    public class CityController : Controller
    {
        private readonly CityManager _cityManager;

        public CityController()
        {
            _cityManager = new CityManager();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_cityManager.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CountryList = _cityManager.CountryList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(City aCity)
        {
            if(ModelState.IsValid)
            {
                bool isSave = _cityManager.Add(aCity);

                if (isSave)
                    return RedirectToAction("Index", "City");
                else
                    return ViewBag.ErrorMessage = "City failed to save!";
            }

            ViewBag.CountryList = _cityManager.CountryList();
            return View(aCity);
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
                return NotFound();

            City aCity = _cityManager.GetById(Id);

            if (aCity == null)
                return NotFound();

            ViewBag.CountryList = _cityManager.CountryList();
            return View(aCity);
        }

        [HttpPost]
        public IActionResult Edit(City aCity)
        {
            if(ModelState.IsValid)
            {
                bool isUpdate = _cityManager.Update(aCity);

                if (isUpdate)
                    return RedirectToAction("Index", "City");
                else
                    return ViewBag.ErrorMessage = "City update failed!";
            }

            ViewBag.CountryList = _cityManager.CountryList();
            return View(aCity);
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
                return NotFound();

            City aCity = _cityManager.GetById(Id);

            if (aCity == null)
                return NotFound();

            return View(aCity);
        }

        [HttpPost]
        public IActionResult Delete(City aCity)
        {
            bool isDelete = _cityManager.Remove(aCity);

            if (isDelete)
                return RedirectToAction("Index", "City");
            else
                return ViewBag.Error = "City delete is failed!";
        }
    }
}