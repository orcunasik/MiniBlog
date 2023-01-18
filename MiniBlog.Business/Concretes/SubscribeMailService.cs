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
    public class SubscribeMailService : Service<SubscribeMail>, ISubscribeMailService
    {
        public SubscribeMailService(IGenericRepositoryDal<SubscribeMail> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
