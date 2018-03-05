using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaotiK.GraphQL.Models;

namespace KaotiK.GraphQL.Data
{
    public interface ICategoryRepository
    {
        Task<List<Category>> CategoriesAsync();
        Task<Category> GetCategoryAsync(int id);
    }
}
