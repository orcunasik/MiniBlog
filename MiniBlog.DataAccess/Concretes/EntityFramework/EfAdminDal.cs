using MiniBlog.DataAccess.Abstractions;
using MiniBlog.DataAccess.Concretes.EntityFramework.Contexts;
using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.DataAccess.Concretes.EntityFramework
{
    public class EfAdminDal : EfGenericRepositoryDal<Admin>, IAdminDal
    {
        public EfAdminDal(MiniBlogContext context) : base(context)
        {
        }
    }
}
