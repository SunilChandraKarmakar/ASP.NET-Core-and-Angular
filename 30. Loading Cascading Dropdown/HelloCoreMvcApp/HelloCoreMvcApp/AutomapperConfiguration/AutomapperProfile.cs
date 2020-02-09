using AutoMapper;
using HelloCoreMvcApp.Models.Product;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCoreMvcApp.AutomapperConfiguration
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Product, ProductIndexViewModel>();
            CreateMap<ProductCreateViewModel, Product>();
        }
    }
}
