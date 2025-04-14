// File: Controllers/ProductController.cs

using Microsoft.AspNetCore.Mvc;
using ProductManagement.Models;
using System.Collections.Generic;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            // Sample data for products
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99M, InStock = true },
                new Product { Id = 2, Name = "Headphones", Price = 149.99M, InStock = false },
                new Product { Id = 3, Name = "Mouse", Price = 49.99M, InStock = true }
            };
            // Count the products and pass it to the view using ViewBag
            ViewBag.ProductCount = products.Count;
            // Return the view with the list of products
            return View(products);
        }
    }
}