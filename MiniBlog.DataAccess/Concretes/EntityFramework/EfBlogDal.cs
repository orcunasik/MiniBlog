using MiniBlog.DataAccess.Abstractions;
using MiniBlog.DataAccess.Concretes.EntityFramework.Contexts;
using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.DataAccess.Concretes.EntityFramework
{
    public class EfBlogDal : EfGenericRepositoryDal<Blog>, IBlogDal
    {
        public EfBlogDal(MiniBlogContext context) : base(context)
        {
        }

        public IQueryable<Blog> GetBlogByAuthor(int id)
        {
            return _context.Blogs.Where(i => i.AuthorId == id).AsQueryable();
        }

        public IQueryable<Blog> GetBlogById(int id)
        {
            return _context.Blogs.Where(i => i.Id == id).AsQueryable();
        }

        public IQueryable<Blog> GetBlogByCategory(int id)
        {
            return _context.Blogs.Where(i => i.CategoryId == id).AsQueryable();
        }

    }
}
