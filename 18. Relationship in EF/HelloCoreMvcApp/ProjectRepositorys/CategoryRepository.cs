using Db_Context.DatabaseContext;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectRepositorys
{
    public class CategoryRepository
    {
        private CoreDb _coreDb = new CoreDb(); 

        public List<Category> CategoryList()
        {
            List<Category> categoryList = _coreDb.Categories.ToList();
            return categoryList;
        }
    }
}
