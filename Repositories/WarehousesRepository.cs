using System.Collections.Generic;
using System.Data;
using System.Linq;
using AmaZen.Interfaces;
using AmaZen.Models;
using Dapper;

namespace AmaZen.Repositories
{
    public class WarehousesRepository : IRepo<Warehouse>
    {
        private readonly IDbConnection _db;

        public WarehousesRepository(IDbConnection db)
        {
            _db = db;
        }
        public Warehouse Create(Warehouse data)
        {
            throw new System.NotImplementedException();
        }

        public List<Warehouse> GetAll()
        {
            string sql = "SELECT * FROM warehouses";
            return _db.Query<Warehouse>(sql).ToList();
        }

        public Warehouse GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Warehouse Update(Warehouse data)
        {
            throw new System.NotImplementedException();
        }
    }
}