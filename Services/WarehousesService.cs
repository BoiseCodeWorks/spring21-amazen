using System;
using System.Collections.Generic;
using System.Linq;
using AmaZen.Models;
using AmaZen.Repositories;

namespace AmaZen.Services
{
    public class WarehousesService
    {
        private readonly WarehousesRepository _warehousesRepo;

        public WarehousesService(WarehousesRepository warehouseRepo)
        {
            _warehousesRepo = warehouseRepo;
        }

        public List<Warehouse> GetAll()
        {
            return _warehousesRepo.GetAll();
        }
    }
}