using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GridifyAdvanceFiltering.Models;

namespace GridifyAdvanceFiltering.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            // Sample data
            _products = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Price = 10.99m, Category = "Category1" },
            new Product { Id = 2, Name = "Product B", Price = 56.99m, Category = "Category2" },
            new Product { Id = 3, Name = "Product C", Price = 11.99m, Category = "Category3" },
            new Product { Id = 4, Name = "Product D", Price = 30.99m, Category = "Category4" },
            new Product { Id = 5, Name = "Product E", Price = 20.99m, Category = "Category5" },
            new Product { Id = 6, Name = "Product F", Price = 45.99m, Category = "Category6" },
            new Product { Id = 7, Name = "Product G", Price = 23.99m, Category = "Category7" },
            // Add more products
        };
        }

        public IQueryable<Product> GetProducts()
        {
            return _products.AsQueryable();
        }
    }
}