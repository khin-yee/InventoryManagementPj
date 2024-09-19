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
        Task<List<AccountCollection>> GetAccount();
         Task<AccountCollection> GetAccountAuth(string username, string password);
        Task AddProduct(ProductDto product);

    }
}
