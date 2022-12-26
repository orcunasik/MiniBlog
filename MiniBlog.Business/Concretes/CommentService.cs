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
    public class CommentService : Service<Comment>, ICommentService
    {
        public CommentService(IGenericRepository<Comment> repository, IUnitOfWork unitOfWork = null) : base(repository, unitOfWork)
        {
        }
    }
}
