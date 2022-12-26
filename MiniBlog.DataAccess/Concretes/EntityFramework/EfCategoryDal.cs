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
    public class EfCategoryDal : EfGenericRepositoryBase<Category>, ICategoryDal
    {
        public EfCategoryDal(MiniBlogContext context) : base(context)
        {
        }
    }
}
