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
    public class BlogService : Service<Blog>, IBlogService
    {
        private readonly IBlogDal _blogDal;
        public BlogService(IGenericRepositoryDal<Blog> repository, IUnitOfWork unitOfWork, IBlogDal blogDal) : base(repository, unitOfWork)
        {
            _blogDal = blogDal;
        }

        public IEnumerable<Blog> GetBlogByAuthor(int id)
        {
            return _blogDal.GetBlogByAuthor(id).ToList();
        }

        public IEnumerable<Blog> GetBlogById(int id)
        {
            return _blogDal.GetBlogById(id).ToList();
        }

        public IEnumerable<Blog> GetBlogByCategory(int id)
        {
            return _blogDal.GetBlogByCategory(id).ToList();
        }

    }
}
