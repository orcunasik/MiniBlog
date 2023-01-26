using MiniBlog.Business.Abstractions;
using MiniBlog.Entities.Concretes;
using System.Linq;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers.AdminControllers
{
    public class AdminAuthorsController : Controller
    {
        private readonly IAuthorService _authorService;
        private readonly IBlogService _blogService;

        public AdminAuthorsController(IAuthorService authorService, IBlogService blogService)
        {
            _authorService = authorService;
            _blogService = blogService;
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
        public ActionResult AuthorBlogs(int id)
        {
            var blogId = _blogService.GetAll()
                .Where(b => b.Id == id)
                .Select(a => a.AuthorId).FirstOrDefault();
            var authorBlogs = _blogService.GetBlogByAuthor(blogId);
            return View(authorBlogs);
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

        public ActionResult AuthorBlogDetail(int id)
        {
            var authorBlogs = _blogService.GetById(id);
            return PartialView(authorBlogs);
        }
    }
}