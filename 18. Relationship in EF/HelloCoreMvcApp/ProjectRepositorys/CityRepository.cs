using Db_Context.DatabaseContext;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectRepositorys
{
    public class CityRepository
    {
        private CoreDb _coreDb = new CoreDb();

        public List<City> Cities()
        {
            return _coreDb.Cities.ToList();
        }

        public List<Country> countries()
        {
            return _coreDb.Countries.ToList();
        }

        public bool Add(City aCity)
        {
            _coreDb.Cities.Add(aCity);
            return _coreDb.SaveChanges() > 0;
        }
    }
}
