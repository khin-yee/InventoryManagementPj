using Amazon.SecurityToken.Model.Internal.MarshallTransformations;
using BlazorApi.Repository.Domain;
using BlazorApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<List<ProductCollection>> GetProduct()
        {
            return await _service.GetProducts();
        }
        [HttpGet("/account")]
        public async Task<List<AccountCollection>> GetAccount()
        {
            return await _service.GetAccount();
        }
        [HttpPost("/AccValidate")]
        public async Task<AccountCollection> GetAccountByAuth([FromForm] string username, [FromForm] string password)
        {
            return await _service.GetAccountAuth(username,password);
        }
        [HttpPost("/AddUser")]
        public async Task AddUer(SignIn signin)
        {
            await _service.AddUser(signin);
        }
        [HttpPost]
        public async Task AddProduct(ProductDto product) 
        {
             await _service.AddProduct(product);
        }

    }
}
