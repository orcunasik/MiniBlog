using MiniBlog.Business.Abstractions;
using MiniBlog.DataAccess.Abstractions;
using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Business.Concretes
{
    public class AdminService : Service<Admin>, IAdminService
    {
        public AdminService(IGenericRepository<Admin> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
