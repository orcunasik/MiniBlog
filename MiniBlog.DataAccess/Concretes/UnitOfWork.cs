using MiniBlog.DataAccess.Abstractions;
using MiniBlog.DataAccess.Concretes.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.DataAccess.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MiniBlogContext _context;

        public UnitOfWork(MiniBlogContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
