using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BlazorApi.Repository.Domain;
using BlazorApi.Repository.Repository;

namespace BlazorApi.Service
{
    public  class ProductService:IProductService
    {
        private readonly IProductRepository<ProductCollection> _repo;
       public ProductService(IProductRepository<ProductCollection> repo)
       {
            _repo = repo;
       }

       public async Task<List<ProductCollection>> GetProducts()
       {
            var res =  await _repo.GetAsync();
            return res;
       }
    }
}
