﻿using MiniBlog.DataAccess.Abstractions;
using MiniBlog.DataAccess.Concretes.EntityFramework;
using MiniBlog.DataAccess.Concretes.EntityFramework.Contexts;
using MiniBlog.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IGenericRepository<T> GetRepository<T>() where T : class, IEntity, new()
        {
            return new EfGenericRepositoryBase<T>(_context);
        }

        public void Commit()
        {
            _context.SaveChanges();
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