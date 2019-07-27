using System;
using MongoDB.Driver;

namespace OfficeMate.MongoDB.Context
{
    public abstract class MongoDBContext : IMongoDBContext
    {
        public IMongoDatabase MongoDatabase { get; }
        public MongoDBContext(string connectionString, string databaseName, bool isSSL)
        {
            //MongoDatabase = new MongoClient(connectionString).GetDatabase(new MongoUrl(connectionString).DatabaseName);

            try
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
                if (isSSL)
                {
                    settings.SslSettings = new SslSettings { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
                }

                var mongoClient = new MongoClient(settings);
                MongoDatabase = mongoClient.GetDatabase(databaseName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
