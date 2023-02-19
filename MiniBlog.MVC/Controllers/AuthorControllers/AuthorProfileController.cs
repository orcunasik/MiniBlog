using MiniBlog.Business.Abstractions;
using MiniBlog.Entities.Concretes;
using System.Linq;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers.AuthorControllers
{
    public class AuthorProfileController : Controller
    {
        private readonly IAuthorService _authorService;
        private readonly IBlogService _blogService;

        public AuthorProfileController(IAuthorService authorService, IBlogService blogService)
        {
            _authorService = authorService;
            _blogService = blogService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult AuthorProfilePartialView(string email)
        {
            email = (string)Session["Email"];
            var profileValues = _authorService.GetAuthorByEmail(email);
            return PartialView(profileValues);
        }

        [HttpPost]
        public ActionResult ProfileUpdate(Author author)
        {
            _authorService.Update(author);
            return RedirectToAction(nameof(Index));
        }

    }
}