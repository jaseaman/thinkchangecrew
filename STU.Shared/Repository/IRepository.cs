using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STU.Common.Repository
{
    public interface IRepository<T>
    {
        T GetById(object id);
        Task<T> GetByIdAsync(object id);
        void Add(T obj);
        Task AddAsync(T obj);
        void Remove(object id);
        Task RemoveAsync(object id);
        void Update(object id, T obj);
        Task UpdateAsync(object id, T obj);
        T All(Func<T, bool> expression);
        Task<T> AllAsync(Func<T, bool> expression);
    }
}
