using System.Collections.Generic;
using System.Data;
using System.Linq;
using AmaZen.Interfaces;
using AmaZen.Models;
using Dapper;

namespace AmaZen.Repositories
{
    public class ProductsRepository : IRepo<Product>
    {
        private readonly IDbConnection _db;

        public ProductsRepository(IDbConnection db)
        {
            _db = db;
        }

        public Product Create(Product data)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAll()
        {
            string sql = "SELECT * FROM products";
            return _db.Query<Product>(sql).ToList();
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product Update(Product data)
        {
            throw new System.NotImplementedException();
        }
    }
}