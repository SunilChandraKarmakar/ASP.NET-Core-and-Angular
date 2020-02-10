using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCoreMvcApp.Models.Product
{
    public class ProductCreateViewModel
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }   
        public List<SelectListItem> CategoryList { get; set; }
    }
}
