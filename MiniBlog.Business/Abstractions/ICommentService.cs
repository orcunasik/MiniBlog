using MiniBlog.Entities.Concretes;
using System.Collections.Generic;

namespace MiniBlog.Business.Abstractions
{
    public interface ICommentService : IService<Comment>
    {
        List<Comment> GetCommentsByBlog();
        IEnumerable<Comment> GetCommentByBlog(int id);
        int CommentStatusToChange(int id);
    }
}
