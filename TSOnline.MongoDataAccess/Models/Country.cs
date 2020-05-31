using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
using TSOnline.Common.Interfaces.Models;

namespace TSOnline.MongoDataAccess.Models
{
    public class Country : ICountry
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("id")]
        public string Id { get; set; }

        [BsonIgnore]
        public string Iso3Code => Id;

        [BsonElement("iso2Code")]
        public string Iso2Code { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonIgnoreIfNull]
        [BsonElement("region")]
        [BsonSerializer(typeof(ImpliedImplementationInterfaceSerializer<IRegion, Region>))]
        public IRegion Region { get; set; }

        [BsonIgnoreIfNull]
        [BsonElement("adminregion")]
        [BsonSerializer(typeof(ImpliedImplementationInterfaceSerializer<IAdminRegion, AdminRegion>))]
        public IAdminRegion AdminRegion { get; set; }

        [BsonIgnoreIfNull]
        [BsonElement("incomeLevel")]
        [BsonSerializer(typeof(ImpliedImplementationInterfaceSerializer<IIncomeLevel, IncomeLevel>))]
        public IIncomeLevel IncomeLevel { get; set; }

        [BsonIgnoreIfNull]
        [BsonElement("lendingType")]
        [BsonSerializer(typeof(ImpliedImplementationInterfaceSerializer<ILendingType, LendingType>))]
        public ILendingType LendingType { get; set; }

        [BsonElement("capitalCity")]
        public string CapitalCity { get; set; }

        [BsonElement("longitude")]
        public decimal Longitude { get; set; }

        [BsonElement("latitude")]
        public decimal Latitude { get; set; }

        [BsonElement("witsId")]
        public int WitsId { get; set; }

        [BsonElement("isreporter")]
        public bool IsReporter { get; set; }

        [BsonElement("ispartner")]
        public bool IsPartner { get; set; }
    }
}
