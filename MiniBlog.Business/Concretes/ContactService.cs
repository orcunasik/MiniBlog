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
    public class ContactService : Service<Contact>, IContactService
    {
        public ContactService(IGenericRepository<Contact> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
