using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BlazorApi.Repository.Domain;
using BlazorApi.Repository.Repository;
using MongoDB.Bson;

namespace BlazorApi.Service
{
    public  class ProductService:IProductService
    {
        private readonly IMapper _mapper;

        private readonly IProductRepository<ProductCollection> _repo;
       public ProductService(IProductRepository<ProductCollection> repo,IMapper mapper)
       {
            _repo = repo;
            _mapper = mapper;
       }

       public async Task<List<ProductCollection>> GetProducts()
       {
            var res =  await _repo.GetAsync();
            return res;
       }
        //public async Task AddProduct(ProductDto product)
        //{
        //    var Product = _mapper.Map<ProductCollection>(product);
        //    await _repo.AddProduct(Product);
        //}
        public async Task AddProduct(ProductDto product)
        {
            if (_mapper == null)
            {
                throw new InvalidOperationException("Mapper not initialized.");
            }

            if (_repo == null)
            {
                throw new InvalidOperationException("Repository not initialized.");
            }

            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "ProductDto cannot be null.");
            }

            var Product = _mapper.Map<ProductCollection>(product);
            Product.Id = ObjectId.GenerateNewId();

            if (Product == null)
            {
                throw new InvalidOperationException("Mapping resulted in null ProductCollection.");
            }

            await _repo.AddProduct(Product);
        }

    }
}
