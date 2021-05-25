
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AmaZen.Interfaces;
using Dapper;

namespace AmaZen.Repositories
{
    public class WarehouseProductsRepository
    {
        private readonly IDbConnection _db;

        public WarehouseProductsRepository(IDbConnection db)
        {
            _db = db;
        }

        public WarehouseProduct Create(WarehouseProduct wp)
        {
            string sql = @"INSERT INTO 
            warehouse_products(warehouseId, productId)
            VALUES (@WarehouseId, @ProductId);
            SELECT LAST_INSERT_ID();
            ";

            wp.Id = _db.ExecuteScalar<int>(sql, wp);
            return wp;
        }

        internal List<WarehouseProductViewModel> GetProductByWarehouseId(int warehouseId)
        {
            string sql = @"
                SELECT
                p.*,
                w.location,
                wp.id as warehouseProductId,
                wp.productId as productId,
                wp.warehouseId as warehouseId
                FROM
                warehouse_products wp
                JOIN warehouses w ON w.id = wp.warehouseId
                JOIN products p ON p.id = wp.productId
                WHERE
                wp.warehouseId = @warehouseId;
            ";
            return _db.Query<WarehouseProductViewModel>(sql, new { warehouseId }).ToList();
        }
    }
}