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
        public void Add(T obj)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public T All(Func<T, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Task<T> AllAsync(Func<T, bool> expression)
        {
            throw new NotImplementedException();
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