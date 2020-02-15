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
    public class CountryManager : Manager<Country>, ICountryManager
    {
        private readonly ICountryRepository _iCountryRepository;

        public CountryManager(ICountryRepository iCountryRepository) : base(iCountryRepository)
        {
            _iCountryRepository = iCountryRepository;
        }        
    }
}
