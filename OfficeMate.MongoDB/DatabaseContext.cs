using OfficeMate.MongoDB.Context;

namespace OfficeMate.MongoDB
{
    public sealed class DatabaseContext : MongoDBContext
    {
        public DatabaseContext(string connectionString, string databaseName, bool isSSL) : base(connectionString, databaseName, isSSL)
        {
        }
    }
}
