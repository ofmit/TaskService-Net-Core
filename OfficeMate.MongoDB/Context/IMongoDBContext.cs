using MongoDB.Driver;

namespace OfficeMate.MongoDB.Context
{
    public interface IMongoDBContext
    {
         IMongoDatabase MongoDatabase { get; }
    }
}
