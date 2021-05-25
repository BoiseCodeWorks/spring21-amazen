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
        private readonly WarehouseProductsRepository _warehouseProductsRepo;

        public WarehousesService(WarehousesRepository warehousesRepo, WarehouseProductsRepository warehouseProductsRepo)
        {
            _warehousesRepo = warehousesRepo;
            _warehouseProductsRepo = warehouseProductsRepo;
        }

        public List<Warehouse> GetAll()
        {
            return _warehousesRepo.GetAll();
        }

        public List<WarehouseProductViewModel> GetProducts(int warehouseId)
        {
            return _warehouseProductsRepo.GetProductByWarehouseId(warehouseId);
        }

        public WarehouseProduct CreateWarehouseProduct(WarehouseProduct wp)
        {
            return _warehouseProductsRepo.Create(wp);
        }

    }
}