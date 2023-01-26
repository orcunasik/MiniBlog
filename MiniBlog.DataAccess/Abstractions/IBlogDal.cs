using MiniBlog.Entities.Concretes;
using System.Linq;

namespace MiniBlog.DataAccess.Abstractions
{
    public interface IBlogDal : IGenericRepositoryDal<Blog>
    {
        IQueryable<Blog> GetBlogByCategory(int id);
        IQueryable<Blog> GetBlogById(int id);
        IQueryable<Blog> GetBlogByAuthor(int id);
    }
}
