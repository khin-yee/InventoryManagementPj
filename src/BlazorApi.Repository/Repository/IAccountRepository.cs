using BlazorApi.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApi.Repository.Repository
{
    public interface IAccountRepository<T> where T:AccountCollection
    {
        Task<List<T>> GetAsync();
        Task<T> GetAsyncByAuth(string username, string password);

    }
}
