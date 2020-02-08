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
    public class CategoryManager : Manager<Category>, ICategoryManager
    {
        private readonly ICategoryRepository _iCategoryRepository;

        public CategoryManager(ICategoryRepository iCategortRepository) : base(iCategortRepository)
        {
            _iCategoryRepository = iCategortRepository;
        }
    }
}
