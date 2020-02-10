using Business_Logic_Layer.BLL;
using Business_Logic_Layer.Contracts;
using Models;
using ProjectRepositorys;
using ProjectRepositorys.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer
{
    public class CityManager : Manager<City>, ICityManager
    {
        private readonly ICityRepository _iCityRepository;

        public CityManager(ICityRepository iCityRepository) : base(iCityRepository)
        {
            _iCityRepository = iCityRepository;
        }
    }
}
