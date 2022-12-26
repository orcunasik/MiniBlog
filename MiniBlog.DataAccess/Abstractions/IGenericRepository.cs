using MiniBlog.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.DataAccess.Abstractions
{
    public interface IGenericRepository<T> where T : class, IEntity, new()
    {
        T GetById(int id);
        IQueryable<T> Where(Expression<Func<T,bool>> expression);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);

    }
}
