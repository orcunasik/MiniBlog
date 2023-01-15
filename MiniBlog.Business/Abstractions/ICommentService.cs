using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Business.Abstractions
{
    public interface ICommentService : IService<Comment>
    {
        List<Comment> GetCommentsByBlog();
        IEnumerable<Comment> GetCommentByBlog(int id);
    }
}
