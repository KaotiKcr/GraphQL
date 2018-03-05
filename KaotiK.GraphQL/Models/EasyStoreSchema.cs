using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaotiK.GraphQL.Data;
using GraphQL.Types;

namespace KaotiK.GraphQL.Models
{
    public class EasyStoreSchema : Schema
    {
        public EasyStoreSchema(Func<Type, GraphType> resolveType)
           : base(resolveType)
        {
            Query = (EasyStoreQuery)resolveType(typeof(EasyStoreQuery));
        }
    }
}
