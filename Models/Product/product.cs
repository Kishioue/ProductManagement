// File: Models/Product.cs

namespace ProductManagement.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
    }
}