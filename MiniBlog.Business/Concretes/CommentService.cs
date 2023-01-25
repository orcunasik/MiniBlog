using MiniBlog.Business.Abstractions;
using MiniBlog.DataAccess.Abstractions;
using MiniBlog.Entities.Concretes;
using System.Collections.Generic;
using System.Linq;

namespace MiniBlog.Business.Concretes
{
    public class CommentService : Service<Comment>, ICommentService
    {
        private readonly ICommentDal _commentDal;
        public CommentService(IGenericRepositoryDal<Comment> repository, IUnitOfWork unitOfWork, ICommentDal commentDal) : base(repository, unitOfWork)
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

        public int CommentStatusToChange(int id)
        {
            var comment = _commentDal.GetById(id);
            if (comment.IsActive == true)
                comment.IsActive = false;
            else
                comment.IsActive = true;
            return _commentDal.Update(comment);
        }

    }
}
