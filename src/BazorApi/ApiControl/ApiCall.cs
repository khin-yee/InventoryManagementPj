using BazorApi.Model;
using BlazorApi.Repository.Domain;
using Newtonsoft.Json;
using System.Text;

namespace BazorApi.ApiControl
{
    public class ApiCall:IApiCall
    {
        private readonly IHttpClientService _http;
        public ApiCall(IHttpClientService http)
        {
            _http = http;
        }
        public async Task<List<Model.ProductCollection>> GetProduct()
        {
           var res = await _http.SendAsync<Model.ProductCollection>("https://localhost:7094/api/Product","100",null,HttpMethod.Get);
           return res;
        }
        public async Task<AccountCollection> GetAccountAuth(string username,string password)
        {
            var parameters = new List<KeyValuePair<string, string>>
                                {
                                    new KeyValuePair<string, string>("Username", username),
                                    new KeyValuePair<string, string>("Password", password)
                                };

            var encodedContent = new FormUrlEncodedContent(parameters);

            var res = await _http.SendOneAsync<AccountCollection>("https://localhost:7094/AccValidate", "100", encodedContent, HttpMethod.Post);
            return res;
        }
    }
    

}
