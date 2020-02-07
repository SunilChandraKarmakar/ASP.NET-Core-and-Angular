using Business_Logic_Layer.BLL;
using Models;
using ProjectRepositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer
{
    public class CategoryManager : Manager<Category>
    {
        public CategoryManager() : base(new CategoryRepository())
        {

        }
    }
}
