using MiniBlog.DataAccess.Abstractions;
using MiniBlog.DataAccess.Concretes.EntityFramework.Contexts;
using MiniBlog.Entities.Concretes;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MiniBlog.DataAccess.Concretes.EntityFramework
{
    public class EfCommentDal : EfGenericRepositoryDal<Comment>, ICommentDal
    {
        public EfCommentDal(MiniBlogContext context) : base(context)
        {
        }

        public List<Comment> GetCommentsByBlog()
        {
            return _context.Comments.Include(i => i.Blog).ToList();
        }

        public IQueryable<Comment> GetCommentByBlog(int id)
        {
            return _context.Comments.Where(i => i.BlogId == id).AsQueryable();
        }
    }
}
