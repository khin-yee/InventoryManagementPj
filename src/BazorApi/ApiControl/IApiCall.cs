using BazorApi.Model;
using BlazorApi.Repository.Domain;

namespace BazorApi.ApiControl
{
    public interface IApiCall
    {
        Task<List<Model.ProductCollection>> GetProduct();
        Task<AccountCollection> GetAccountAuth(string username, string password);

    }
}
