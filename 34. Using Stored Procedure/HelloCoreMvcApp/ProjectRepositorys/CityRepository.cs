using Db_Context.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Models;
using ProjectRepositorys.Base;
using ProjectRepositorys.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectRepositorys
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository()
        {
            _coreDb = new CoreDb();
        }

        public override ICollection<City> GetAll()
        {
            return _coreDb.Cities.Include(c=>c.Country).ToList();
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
    }
}
