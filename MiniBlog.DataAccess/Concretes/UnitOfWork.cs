using MiniBlog.DataAccess.Abstractions;
using MiniBlog.DataAccess.Concretes.EntityFramework;
using MiniBlog.DataAccess.Concretes.EntityFramework.Contexts;
using MiniBlog.Entities.Abstractions;
using System;

namespace MiniBlog.DataAccess.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private readonly MiniBlogContext _context;
        public UnitOfWork(MiniBlogContext context)
        {
            _context = context;
        }

        public IGenericRepositoryDal<T> GetRepository<T>() where T : class, IEntity, new()
        {
            return new EfGenericRepositoryDal<T>(_context);
        }

        public void Commit()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
