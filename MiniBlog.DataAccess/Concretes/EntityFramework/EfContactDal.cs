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
    public class EfContactDal : EfGenericRepositoryDal<Contact>, IContactDal
    {
        public EfContactDal(MiniBlogContext context) : base(context)
        {
        }
    }
}
