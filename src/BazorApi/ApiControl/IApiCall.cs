using BazorApi.Model;

namespace BazorApi.ApiControl
{
    public interface IApiCall
    {
        Task<List<ProductCollection>> GetProduct();
        Task<AccountCollection> GetAccountAuth(string username, string password);
        Task<bool> AddAccount(SignIn account);

    }
}
