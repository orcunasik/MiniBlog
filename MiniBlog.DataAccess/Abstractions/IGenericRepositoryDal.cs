using MiniBlog.Entities.Abstractions;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace MiniBlog.DataAccess.Abstractions
{
    public interface IGenericRepositoryDal<T> where T : class, IEntity, new()
    {
        T GetById(int id);
        IQueryable<T> Where(Expression<Func<T,bool>> expression);
        IQueryable<T> GetAll();
        void Add(T entity);
        int Update(T entity);
        void Remove(T entity);

    }
}
