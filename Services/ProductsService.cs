using System;
using System.Collections.Generic;
using AmaZen.Models;
using AmaZen.Repositories;

namespace AmaZen.Services
{
    public class ProductsService
    {
        private readonly ProductsRepository _productsRepository;

        public ProductsService(ProductsRepository ps)
        {
            _productsRepository = ps;
        }

        public List<Product> GetAll()
        {
            return _productsRepository.GetAll();
        }
    }
}