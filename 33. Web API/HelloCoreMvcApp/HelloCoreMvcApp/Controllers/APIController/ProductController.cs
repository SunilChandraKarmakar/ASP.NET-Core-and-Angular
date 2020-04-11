using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business_Logic_Layer.Contracts;
using HelloCoreMvcApp.Models.Product;
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
        private readonly IMapper _iMapper;

        public ProductController(IProductManager iProductManager, IMapper iMapper)
        {
            _iProductManager = iProductManager;
            _iMapper = iMapper;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _iProductManager.GetAll(); 
        }

        //[HttpGet("{id}")]
        //public Product Get(int id)
        //{
        //    return _iProductManager.GetById(id);
        //}

        [HttpPost]
        public IActionResult Post(Product aProduct)
        {
            if(ModelState.IsValid)
            {
                bool isSave = _iProductManager.Add(aProduct);

                if (isSave)
                    return Ok(aProduct);
                else
                    return BadRequest(new { ErrorMessage = "Product post is failed!" });
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Product aProduct)
        {
            Product existsProduct = _iProductManager.GetById(id);

            if (existsProduct == null)
                return BadRequest(new { ErrorMessage = "No product found!" });

            if(ModelState.IsValid)
            {
                existsProduct.CategoryId = aProduct.CategoryId;
                existsProduct.Description = aProduct.Description;
                existsProduct.IsActive = aProduct.IsActive;
                existsProduct.Name = aProduct.Name;
                existsProduct.Price = aProduct.Price;
                existsProduct.OrderDetails = aProduct.OrderDetails;
                existsProduct.Category = aProduct.Category;

                bool isPut = _iProductManager.Update(existsProduct);

                if (isPut)
                    return Ok();
                else
                    return BadRequest(new { ErrorMessage = "Product put is failed!" });
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Product existsProduct = _iProductManager.GetById(id);

            if (existsProduct == null)
                return BadRequest();

            bool isDelete = _iProductManager.Remove(existsProduct);

            if (isDelete)
                return Ok();
            else
                return BadRequest(new { ErrorMessage = "Product delete is failed!" });
        }
    }
}