using MiniBlog.Entities.Concretes;
using System.Collections.Generic;

namespace MiniBlog.Business.Abstractions
{
    public interface IAuthorService : IService<Author>
    {
        Author AuthorLogin(Author author);
        //bool ValidateCredentials(string authorEmail, string password);
        IEnumerable<Author> GetAuthorByEmail(string email);

    }
}
