using AA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AA.Core.DataAccess
{
    public interface IEntityRepository<T, in TKey>
        where T : class, IEntity<TKey>, new()
        where TKey : IEquatable<TKey>
    {
        T GetById(string id);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(string id);
    }
}
