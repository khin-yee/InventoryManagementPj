using BlazorApi.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApi.Service
{
    public  interface IProductService
    {
        Task<List<ProductCollection>> GetProducts();
        Task AddProduct(ProductDto product);

    }
}
