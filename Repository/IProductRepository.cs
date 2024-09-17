using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GridifyAdvanceFiltering.Models;

namespace GridifyAdvanceFiltering.Repository
{
    public interface IProductRepository
    {
        IQueryable<Product> GetProducts();
    }
}