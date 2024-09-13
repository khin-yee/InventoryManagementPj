namespace BazorApi.ApiControl
{
    public interface IHttpClientService
    {
        Task<List<T?>> SendAsync<T>(string endpoint, string timeout, FormUrlEncodedContent content, HttpMethod method);

    }
}
