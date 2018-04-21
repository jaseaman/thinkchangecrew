using MongoDB.Driver;
using STU.Shared.Model;
using STU.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace STU.Bot.Repository
{
    public class MongoDbRepository<T> : IRepository<T> where T : BaseModel
    { 
        protected IMongoCollection<T> _entries;

        public MongoDbRepository(MongoClient client, string databaseName)
        {
            _entries = client.GetDatabase(databaseName).GetCollection<T>("STUResponse");
            
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
            return _entries.Find(Builders<T>.Filter.Eq("Id", id)).FirstOrDefault();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await (await _entries.FindAsync(Builders<T>.Filter.Eq("Id", id))).FirstOrDefaultAsync();
        }

        public void Remove(object id)
        {
            _entries.FindOneAndDelete(Builders<T>.Filter.Eq("Id", id));
        }

        public async Task RemoveAsync(object id)
        {
            await _entries.FindOneAndDeleteAsync(Builders<T>.Filter.Eq("Id", id));
        }

        public void Update(object id, T obj)
        {
            _entries.FindOneAndReplace(Builders<T>.Filter.Eq("Id", id), obj);
        }

        public async Task UpdateAsync(object id, T obj)
        {
            await _entries.FindOneAndReplaceAsync(Builders<T>.Filter.Eq("Id", id), obj);
        }
    }
}