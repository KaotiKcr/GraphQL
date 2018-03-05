﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaotiK.GraphQL.Data;
using GraphQL.Types;

namespace KaotiK.GraphQL.Models
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType(ICategoryRepository categoryRepository)
        {
            Field(x => x.Id).Description("Product id.");
            Field(x => x.Name).Description("Product name.");
            Field(x => x.Description, nullable: true).Description("Product description.");
            Field(x => x.Price).Description("Product price.");

            Field<CategoryType>(
                "category",
                resolve: context => categoryRepository.GetCategoryAsync(context.Source.CategoryId).Result
             );
        }
    }
}
