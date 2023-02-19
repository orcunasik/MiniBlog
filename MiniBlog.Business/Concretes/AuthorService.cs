using MiniBlog.Business.Abstractions;
using MiniBlog.DataAccess.Abstractions;
using MiniBlog.Entities.Concretes;
using System.Collections.Generic;
using System.Linq;

namespace MiniBlog.Business.Concretes
{
    public class AuthorService : Service<Author>, IAuthorService
    {
        private readonly IAuthorDal _authorDal;
        public AuthorService(IGenericRepositoryDal<Author> repository, IUnitOfWork unitOfWork, IAuthorDal authorDal) : base(repository, unitOfWork)
        {
            _authorDal = authorDal;
        }

        public Author AuthorLogin(Author author)
        {
            var authorInfo = _authorDal.Where(a => a.Email == author.Email && a.Password == author.Password).FirstOrDefault();
            return authorInfo;
        }

        public IEnumerable<Author> GetAuthorByEmail(string email)
        {
            return _authorDal.Where(a => a.Email == email).ToList();
        }
    }
}
