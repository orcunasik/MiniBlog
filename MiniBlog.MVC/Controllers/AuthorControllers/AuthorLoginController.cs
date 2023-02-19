using MiniBlog.Business.Abstractions;
using MiniBlog.Entities.Concretes;
using System.Web.Mvc;
using System.Web.Security;

namespace MiniBlog.MVC.Controllers.AuthorControllers
{
    public class AuthorLoginController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorLoginController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public ActionResult AuthorLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AuthorLogin(Author author)
        {
            var authorValue = _authorService.AuthorLogin(author);
            if (authorValue != null)
            {
                FormsAuthentication.SetAuthCookie(authorValue.Email, false);
                Session["Email"] = authorValue.Email.ToString();
                return RedirectToAction("Index", "AuthorProfile");
            }
            else
            {
                return RedirectToAction(nameof(AuthorLogin));
            }

        }

        public ActionResult AuthorLogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction(nameof(AuthorLogin));
        }
    }
}