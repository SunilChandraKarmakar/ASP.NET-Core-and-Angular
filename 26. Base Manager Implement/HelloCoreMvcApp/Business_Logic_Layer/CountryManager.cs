using Business_Logic_Layer.BLL;
using Models;
using ProjectRepositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer
{
    public class CountryManager : Manager<Country>
    {
        private readonly CountryRepository _countryRepository;

        public CountryManager() : base(new CountryRepository())
        {
            _countryRepository = new CountryRepository();    
        }        
    }
}
