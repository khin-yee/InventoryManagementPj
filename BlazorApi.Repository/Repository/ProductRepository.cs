using BlazorApi.Repository.Domain;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApi.Repository.Repository
{
    public class ProductRepository<T>:IProductRepository<T> where T :ProductCollection
    {
        private readonly IMongoCollection<T> _mongoDbCollection;

        public ProductRepository(IOptions<DbSetting> mongodatabasesetting)
        {
            var endPointUrl = MongoClientSettings.FromUrl(new MongoUrl(mongodatabasesetting.Value.ConnectionString));
            var mongoClient = new MongoClient(endPointUrl);
            var mongoDatabase = mongoClient.GetDatabase(mongodatabasesetting.Value.DatabaseName);
            _mongoDbCollection = mongoDatabase.GetCollection<T>(mongodatabasesetting.Value.CollectionName);
        }

        public async Task<List<T>> GetAsync()
        {
            try
            {
                return await _mongoDbCollection.Find(x => x.IsDeleted == false).ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
        }

    }


}
