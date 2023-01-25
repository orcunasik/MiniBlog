using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MiniBlog.DataAccess.Abstractions
{
    public interface ICommentDal : IGenericRepositoryDal<Comment>
    {
        List<Comment> GetCommentsByBlog();
        IQueryable<Comment> GetCommentByBlog(int id);
    }
}
