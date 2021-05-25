using System.Collections.Generic;
using AmaZen.Models;
using AmaZen.Services;
using Microsoft.AspNetCore.Mvc;

namespace AmaZen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WarehousesController : ControllerBase
    {
        private readonly WarehousesService _warehousesService;

        public WarehousesController(WarehousesService ws)
        {
            _warehousesService = ws;
        }

        [HttpGet]
        public ActionResult<List<Warehouse>> GetAll()
        {
            try
            {
                List<Warehouse> warehouses = _warehousesService.GetAll();
                return Ok(warehouses);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}/products")]
        public ActionResult<List<WarehouseProductViewModel>> GetWarehouseProducts(int id)
        {
            try
            {
                List<WarehouseProductViewModel> products = _warehousesService.GetProducts(id);
                return Ok(products);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}