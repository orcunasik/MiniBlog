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
        private readonly ICommentDal _commentDal;
        public CommentService(IGenericRepository<Comment> repository, IUnitOfWork unitOfWork, ICommentDal commentDal) : base(repository, unitOfWork)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetCommentsByBlog()
        {
            List<Comment> comments = _commentDal.GetCommentsByBlog();
            return comments;
        }

        public IEnumerable<Comment> GetCommentByBlog(int id)
        {
            return _commentDal.GetCommentByBlog(id).ToList();
        }
    }
}
