using MongoDB.Driver;
using STU.Common.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace STU.Bot.Repository
{
    public class MongoDbRepository<T> : IRepository<T>
    { 
        protected IMongoCollection<T> _entries;

        public MongoDbRepository(MongoClient client, string databaseName)
        {
            _entries = client.GetDatabase(databaseName).GetCollection<T>(nameof(T));
        }

        public void Add(T obj)
        {
            _entries.InsertOne(obj, null);
        }

        public async Task AddAsync(T obj)
        {
            await _entries.InsertOneAsync(obj);
        }

        public IQueryable<T> All(Func<T, bool> expression)
        {
            return _entries.AsQueryable().Where(expression).AsQueryable();
        }

        public async Task<IQueryable<T>> AllAsync(Func<T, bool> expression)
        {
            return await Task.Run(() =>_entries.AsQueryable().Where(expression).AsQueryable());
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public void Remove(object id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(object id)
        {
            throw new NotImplementedException();
        }

        public void Update(object id, T obj)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(object id, T obj)
        {
            throw new NotImplementedException();
        }
    }
}