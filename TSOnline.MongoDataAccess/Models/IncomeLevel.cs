using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using TSOnline.Common.Interfaces.Models;

namespace TSOnline.MongoDataAccess.Models
{
    [BsonNoId]
    public class IncomeLevel : IIncomeLevel
    {
        [BsonElement("id")]
        public string Id { get; set; }

        [BsonIgnore]
        public string Iso3Code => Id;

        [BsonElement("iso2code")]
        public string Iso2Code { get; set; }

        [BsonElement("value")]
        public string Name { get; set; }
    }
}
