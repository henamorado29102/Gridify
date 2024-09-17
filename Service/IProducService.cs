using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gridify;
using GridifyAdvanceFiltering.Models;

namespace GridifyAdvanceFiltering.Service
{
    public interface IProductService
    {
        Paging<Product> GetFilteredProducts(GridifyQuery gridifyQuery);
        List<Product> GetProducts();
    }
}