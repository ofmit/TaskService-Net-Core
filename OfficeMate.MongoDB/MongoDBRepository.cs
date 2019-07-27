using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using OfficeMate.MongoDB.Context;
using OfficeMate.MongoDB.Interface;

namespace OfficeMate.MongoDB.Repositories
{
    public class MongoDBRepository<T> : IMongoDBRepository<T> where T : class
    {
        public MongoDBRepository(DatabaseContext context)
        {
            Database = context.MongoDatabase;
            _collection = Database.GetCollection<T>(typeof(T).Name);
        }

        private IMongoCollection<T> _collection { get; }

        private IMongoDatabase Database { get; }

        public Task AddAsync(T item)
        {
            return _collection.InsertOneAsync(item);
        }

        public Task AddRangeAsync(IEnumerable<T> list)
        {
            return _collection.InsertManyAsync(list);
        }

        public Task<bool> AnyAsync()
        {
            return _collection.Find(new BsonDocument()).AnyAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> where)
        {
            return _collection.Find(where).AnyAsync();
        }

        public Task<long> CountAsync()
        {
            return _collection.CountDocumentsAsync(new BsonDocument());
        }

        public Task<long> CountAsync(Expression<Func<T, bool>> where)
        {
            return _collection.CountDocumentsAsync(where);
        }

        public Task DeleteAsync(object key)
        {
            return _collection.DeleteOneAsync(FilterId(key));
        }

        public Task DeleteAsync(Expression<Func<T, bool>> where)
        {
            return _collection.DeleteManyAsync(where);
        }

        public Task DeleteAllAsync()
        {
            return _collection.DeleteManyAsync(new BsonDocument());
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> where)
        {
            return await _collection.Find(where).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> where)
        {
            return await _collection.Find(where).ToListAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await _collection.Find(new BsonDocument()).ToListAsync().ConfigureAwait(false);
        }

        public Task<T> SelectAsync(object key)
        {
            return _collection.Find(FilterId(key)).SingleOrDefaultAsync();
        }

        public Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> where)
        {
            return _collection.Find(where).SingleOrDefaultAsync();
        }

        public Task UpdateAsync(T item, object key)
        {
            return _collection.ReplaceOneAsync(FilterId(key), item);
        }

        private static FilterDefinition<T> FilterId(object key)
        {
            return Builders<T>.Filter.Eq("Id", ObjectId.Parse(key.ToString()));
        }
    }
}
