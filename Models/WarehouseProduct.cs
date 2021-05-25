using System;
using System.ComponentModel.DataAnnotations;
using AmaZen.Models;

namespace AmaZen
{
    public class WarehouseProduct
    {
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int WarehouseId { get; set; }
    }
    public class WarehouseProductViewModel : Product
    {
        public string Location { get; set; }
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public int WarehouseProductId { get; set; }

    }
}