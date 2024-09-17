using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gridify;
using GridifyAdvanceFiltering.Service;
using Microsoft.AspNetCore.Mvc;

namespace GridifyAdvanceFiltering.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts([FromQuery] GridifyQuery gridifyQuery)
        {
            var products = _productService.GetFilteredProducts(gridifyQuery);
            return Ok(products);
        }

        [HttpGet("products")]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }
    }
}