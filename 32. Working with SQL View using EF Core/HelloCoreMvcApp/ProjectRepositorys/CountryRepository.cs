﻿using Db_Context.DatabaseContext;
using Models;
using ProjectRepositorys.Base;
using ProjectRepositorys.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectRepositorys
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {   
            
    }
}
