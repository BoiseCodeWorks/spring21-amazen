using System;
using System.Collections.Generic;
using System.Linq;
using AmaZen.Models;
using AmaZen.Repositories;

namespace AmaZen.Services
{
    public class WarehouseProductsService
    {
        private readonly WarehouseProductsRepository _warehouseProductsRepo;

        public WarehouseProductsService(WarehousesRepository warehousesRepo, WarehouseProductsRepository warehouseProductsRepo)
        {
            _warehouseProductsRepo = warehouseProductsRepo;
        }

        public WarehouseProduct CreateWarehouseProduct(WarehouseProduct wp)
        {
            return _warehouseProductsRepo.Create(wp);
        }

        internal WarehouseProduct UpdateWarehouseProduct(WarehouseProduct wp)
        {
            throw new NotImplementedException();
        }
    }
}