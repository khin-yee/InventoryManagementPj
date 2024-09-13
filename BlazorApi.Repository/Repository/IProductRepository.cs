using BlazorApi.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApi.Repository.Repository
{
    public  interface IProductRepository<T> where T:ProductCollection
    {
        Task<List<T>> GetAsync();

    }
}
