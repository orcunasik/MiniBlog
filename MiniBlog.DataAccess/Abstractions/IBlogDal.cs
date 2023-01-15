using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.DataAccess.Abstractions
{
    public interface IBlogDal : IGenericRepository<Blog>
    {
        IQueryable<Blog> GetBlogByCategory(int id);
        IQueryable<Blog> GetBlogById(int id);
        IQueryable<Blog> GetBlogByAuthor(int id);
    }
}
