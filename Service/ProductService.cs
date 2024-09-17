using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gridify;
using GridifyAdvanceFiltering.Models;
using GridifyAdvanceFiltering.Repository;

namespace GridifyAdvanceFiltering.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Paging<Product> GetFilteredProducts(GridifyQuery gridifyQuery)
        {

            Paging<Product> result = _productRepository.GetProducts().Gridify(gridifyQuery);

            return result;
        }

        public List<Product> GetProducts()
        {
            return [.. _productRepository.GetProducts()];
        }
    }
}