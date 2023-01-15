using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Business.Abstractions
{
    public interface IBlogService : IService<Blog>
    {
        IEnumerable<Blog> GetBlogByCategory(int id);
        IEnumerable<Blog> GetBlogById(int id);
        IEnumerable<Blog> GetBlogByAuthor(int id);
    }
}
