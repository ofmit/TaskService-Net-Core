using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace OfficeMate.MongoDB.Interface
{
    public interface IMongoDBRepository<T>
    {
        Task AddAsync(T item);

        Task AddRangeAsync(IEnumerable<T> list);

        Task<bool> AnyAsync();

        Task<bool> AnyAsync(Expression<Func<T, bool>> where);

        Task<long> CountAsync();

        Task<long> CountAsync(Expression<Func<T, bool>> where);

        Task DeleteAsync(object key);

        Task DeleteAsync(Expression<Func<T, bool>> where);

        Task DeleteAllAsync();

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> where);

        Task<IEnumerable<T>> FindAllAsync();

        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> where);

        Task<T> SelectAsync(object key);

        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> where);

        Task UpdateAsync(T item, object key);
    }
}
