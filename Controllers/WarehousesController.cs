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
    }
}