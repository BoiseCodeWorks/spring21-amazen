using System.Collections.Generic;
using AmaZen.Models;
using AmaZen.Services;
using Microsoft.AspNetCore.Mvc;

namespace AmaZen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WarehouseProductsController : ControllerBase
    {
        private readonly WarehouseProductsService _warehouseProductsService;

        public WarehouseProductsController(WarehouseProductsService ws)
        {
            _warehouseProductsService = ws;
        }

        [HttpPost]
        public ActionResult<WarehouseProduct> CreateWarehouseProduct([FromBody] WarehouseProduct wp)
        {
            try
            {
                WarehouseProduct newProduct = _warehouseProductsService.CreateWarehouseProduct(wp);
                return Ok(newProduct);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public ActionResult<WarehouseProduct> UpdateWarehouseProduct([FromBody] WarehouseProduct wp)
        {
            try
            {
                WarehouseProduct update = _warehouseProductsService.UpdateWarehouseProduct(wp);
                return Ok(update);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}