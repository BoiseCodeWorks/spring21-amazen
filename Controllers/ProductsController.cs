using System.Collections.Generic;
using AmaZen.Models;
using AmaZen.Services;
using Microsoft.AspNetCore.Mvc;

namespace AmaZen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsService _productsService;

        public ProductsController(ProductsService ps)
        {
            _productsService = ps;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            try
            {
                List<Product> products = _productsService.GetAll();
                return Ok(products);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}