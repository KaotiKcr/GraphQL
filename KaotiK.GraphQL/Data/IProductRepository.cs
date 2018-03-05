using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaotiK.GraphQL.Models;

namespace KaotiK.GraphQL.Data
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();
        Task<List<Product>> GetProductsWithByCategoryIdAsync(int categoryId);
        Task<Product> GetProductAsync(int id);
    }
}
