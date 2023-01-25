using MiniBlog.DataAccess.Abstractions;
using MiniBlog.DataAccess.Concretes.EntityFramework.Contexts;
using MiniBlog.Entities.Abstractions;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

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

        public int Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChanges();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
