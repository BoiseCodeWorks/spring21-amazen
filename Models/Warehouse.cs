using System;

namespace AmaZen.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Location { get; set; }
    }
}