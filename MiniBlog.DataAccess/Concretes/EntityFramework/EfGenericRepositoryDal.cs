using MiniBlog.DataAccess.Abstractions;
using MiniBlog.DataAccess.Concretes.EntityFramework.Contexts;
using MiniBlog.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.DataAccess.Concretes.EntityFramework
{
    public class EfGenericRepositoryDal<T> : IGenericRepositoryDal<T> where T : class, IEntity, new()
    {
        protected readonly MiniBlogContext _context;
        private readonly DbSet<T> _dbSet;
        public EfGenericRepositoryDal(MiniBlogContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
