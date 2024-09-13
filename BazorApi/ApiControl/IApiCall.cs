using BazorApi.Model;

namespace BazorApi.ApiControl
{
    public interface IApiCall
    {
        Task<List<ProductCollection>> GetProduct();
    }
}
