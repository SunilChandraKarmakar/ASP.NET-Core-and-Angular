using Business_Logic_Layer.BLL;
using Models;
using ProjectRepositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer
{
    public class CityManager : Manager<City>
    {
        private readonly CityRepository _cityRepository;

        public CityManager() : base(new CityRepository())
        {
            _cityRepository = new CityRepository();
        }

        public List<Country> CountryList()
        {
            return _cityRepository.CountryList();
        }
    }
}
