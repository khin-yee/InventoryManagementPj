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
    public  class AccountRepository<T>:IAccountRepository<T> where T : AccountCollection
    {
        private readonly IMongoCollection<T> _mongoDbCollection;

        public AccountRepository(IOptions<DbSetting> mongodatabasesetting)
        {
            var endPointUrl = MongoClientSettings.FromUrl(new MongoUrl(mongodatabasesetting.Value.ConnectionString));
            var mongoClient = new MongoClient(endPointUrl);
            var mongoDatabase = mongoClient.GetDatabase(mongodatabasesetting.Value.DatabaseName);
            _mongoDbCollection = mongoDatabase.GetCollection<T>(mongodatabasesetting.Value.AccountCollectionName);
        }
        public async Task AddUser(T Account)
        {
            await _mongoDbCollection.InsertOneAsync(Account);
        }
        public async Task<List<T>> GetAsync()
        {
            try
            {
                return await _mongoDbCollection.Find(x => x.IsActive == true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
        public async Task<T> GetAsyncByAuth(string username,string password)
        {
            try
            {
                var result = await _mongoDbCollection
             .Find(x => x.UserName == username && x.Password == password)
             .FirstOrDefaultAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

    }
}
