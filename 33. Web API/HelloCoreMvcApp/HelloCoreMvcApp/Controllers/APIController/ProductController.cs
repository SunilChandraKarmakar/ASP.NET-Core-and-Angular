using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic_Layer.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace HelloCoreMvcApp.Controllers.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _iProductManager;

        public ProductController(IProductManager iProductManager)
        {
            _iProductManager = iProductManager;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _iProductManager.GetAll(); 
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _iProductManager.GetById(id);
        }
    }
}