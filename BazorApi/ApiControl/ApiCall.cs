using BazorApi.Model;

namespace BazorApi.ApiControl
{
    public class ApiCall:IApiCall
    {
        private readonly IHttpClientService _http;
        public ApiCall(IHttpClientService http)
        {
            _http = http;
        }
        public async Task<List<ProductCollection>> GetProduct()
        {
           var res = await _http.SendAsync<ProductCollection>("https://localhost:7094/api/Product","100",null,HttpMethod.Get);
           return res!;
        }
    }
}
