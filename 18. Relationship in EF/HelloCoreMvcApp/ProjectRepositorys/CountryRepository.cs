using Db_Context.DatabaseContext;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectRepositorys
{
    public class CountryRepository
    {
        private CoreDb _coreDb = new CoreDb();

        public List<Country> CountryList()
        {
            return _coreDb.Countries.ToList();
        }

        public bool Create(Country aCountry)
        {
            _coreDb.Countries.Add(aCountry);
            return _coreDb.SaveChanges() > 0;
        }

        public Country FindCountry(int? Id)
        {
            return _coreDb.Countries.Find(Id);
        }

        public bool Edit(Country aCountry)
        {
            _coreDb.Entry(aCountry).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _coreDb.SaveChanges() > 0;
        }

        public bool Delete(Country aCountry)
        {
            _coreDb.Countries.Remove(aCountry);
            return _coreDb.SaveChanges() > 0;
        }
    }
}
