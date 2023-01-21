using MiniBlog.Business.Abstractions;
using MiniBlog.Entities.Concretes;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers.AdminControllers
{
    public class AdminAuthorsController : Controller
    {
        private readonly IAuthorService _authorService;

        public AdminAuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Authors()
        {
            var authors = _authorService.GetAll();
            return PartialView(authors);
        }
        [HttpGet]
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Author author)
        {
            _authorService.Add(author);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var author = _authorService.GetById(id);
            return View(author);
        }
        [HttpPost]
        public ActionResult Update(Author author)
        {
            _authorService.Update(author);
            return RedirectToAction(nameof(Index));
        }
    }
}