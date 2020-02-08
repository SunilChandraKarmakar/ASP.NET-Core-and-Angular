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
using ProjectRepositorys.Contracts;

namespace HelloCoreMvcApp.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityManager _iCityManager;
        private readonly ICountryManager _iCountryManager;

        public CityController(ICityManager iCityManager, ICountryManager iCountryManager)
        {
            _iCityManager = iCityManager;
            _iCountryManager = iCountryManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_iCityManager.GetAll());
        }

        private List<SelectListItem> CountryListItem()
        {
            List<SelectListItem> countryListItem = _iCountryManager.GetAll()
                                                    .Select(c => new SelectListItem()
                                                    {
                                                        Value = c.Id.ToString(),
                                                        Text = c.Name
                                                    })
                                                    .ToList();
            return countryListItem;
        }

        [HttpGet]
        public IActionResult Create()
        {        
            ViewBag.CountryListItem = CountryListItem();
            return View();
        }

        [HttpPost]
        public IActionResult Create(City aCity)
        {
            if(ModelState.IsValid)
            {
                bool isSave = _iCityManager.Add(aCity);

                if (isSave)
                    return RedirectToAction("Index", "City");
                else
                    return ViewBag.ErrorMessage = "City failed to save!";
            }

            ViewBag.CountryListItem = CountryListItem();
            return View(aCity);
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
                return NotFound();

            City aCity = _iCityManager.GetById(Id);

            if (aCity == null)
                return NotFound();

            ViewBag.CountryListItem = CountryListItem();
            return View(aCity);
        }

        [HttpPost]
        public IActionResult Edit(City aCity)
        {
            if(ModelState.IsValid)
            {
                bool isUpdate = _iCityManager.Update(aCity);

                if (isUpdate)
                    return RedirectToAction("Index", "City");
                else
                    return ViewBag.ErrorMessage = "City update failed!";
            }

            ViewBag.CountryListItem = CountryListItem();
            return View(aCity);
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
                return NotFound();

            City aCity = _iCityManager.GetById(Id);

            if (aCity == null)
                return NotFound();

            return View(aCity);
        }

        [HttpPost]
        public IActionResult Delete(City aCity)
        {
            bool isDelete = _iCityManager.Remove(aCity);

            if (isDelete)
                return RedirectToAction("Index", "City");
            else
                return ViewBag.Error = "City delete is failed!";
        }
    }
}