using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositoryEntityFramework.Interfaces
{
   public interface IRepository<T> where T:class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void AddRange(IEnumerable<T> entity);

        void Remove(T entity);
        void RemoveRage(IEnumerable<T> entity);
    }
}
