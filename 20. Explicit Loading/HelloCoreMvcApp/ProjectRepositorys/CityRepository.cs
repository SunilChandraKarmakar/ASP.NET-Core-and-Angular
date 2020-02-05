using Db_Context.DatabaseContext;
using Microsoft.EntityFrameworkCore;
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
            return _coreDb.Cities.Include(c => c.Country).ToList();
        }

        public List<City> CityWithCountry()
        {
            List<City> cityList = _coreDb.Cities.ToList();

            foreach (City item in cityList)
            {
                _coreDb.Entry(item).Reference(c => c.Country).Load();
            }

            return cityList;
        }

        public List<Country> Countries()
        {
            return _coreDb.Countries.ToList();
        }

        public bool Add(City aCity)
        {
            _coreDb.Cities.Add(aCity);
            return _coreDb.SaveChanges() > 0;
        }       

        public City FindCity(int? Id)
        {
            return _coreDb.Cities.Find(Id);
        }

        public bool Edit(City aCity)
        {
            _coreDb.Entry(aCity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _coreDb.SaveChanges() > 0;
        }

        public bool Delete(City aCity)
        {
            _coreDb.Cities.Remove(aCity);
            return _coreDb.SaveChanges() > 0;
        }
    }
}
