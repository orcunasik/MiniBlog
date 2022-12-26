using MiniBlog.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Business.Abstractions
{
    public interface IService<T> where T : class, IEntity, new()
    {
        T GetById(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetAll();
        T Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
