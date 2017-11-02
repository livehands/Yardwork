using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Yardwork
{
    public interface IRepository<T> where T : class
    {
        IUnitOfWork UnitOfWork { get; }

        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(string id);

        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);

        void Add(T item);
        void AddRange(IEnumerable<T> items);

        void Update(T item);

        void Remove(T item);

        void RemoveRange(IEnumerable<T> items);
    }
}
