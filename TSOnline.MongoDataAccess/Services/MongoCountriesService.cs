using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSOnline.Common.Interfaces.Models;
using TSOnline.Common.Interfaces.Services;
using TSOnline.MongoDataAccess.Models;

namespace TSOnline.MongoDataAccess.Services
{
    public class MongoCountriesService : ICountriesDatabaseService
    {
        #region Fields

        private readonly IMongoCollection<Country> _countries;

        #endregion Fields

        public MongoCountriesService(ITSOnlineDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase("TSOnline_User");

            _countries = database.GetCollection<Country>("Countries");
        }

        public Task<long> EstimatedCountCountriesAsync()
        {
            return _countries.EstimatedDocumentCountAsync();
        }

        public Task<long> CountCountriesAsync()
        {
            return _countries.CountDocumentsAsync(new BsonDocument());
        }

        public Task<List<ICountry>> GetAllAsync()
        {
            return Task.FromResult(_countries.Find(new BsonDocument()).SortBy(c => c.Name).ToList().ToList<ICountry>());
        }
    }
}
