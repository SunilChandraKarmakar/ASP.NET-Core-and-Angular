using Db_Context.DatabaseContext;
using Microsoft.EntityFrameworkCore;
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

        public bool Create(Category aCategory)
        {
            _coreDb.Categories.Add(aCategory);
            return _coreDb.SaveChanges() > 0;
        }

        public Category FindCategory(int? Id)
        {
            return _coreDb.Categories.Find(Id);
        }

        public bool Edit(Category aCategory)
        {
            _coreDb.Entry(aCategory).State = EntityState.Modified;
            return _coreDb.SaveChanges() > 0;
        }

        public bool Delete(Category aCategory)
        {
            _coreDb.Categories.Remove(aCategory);
            return _coreDb.SaveChanges() > 0;
        }
    }
}
