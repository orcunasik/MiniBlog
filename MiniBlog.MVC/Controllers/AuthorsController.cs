using MiniBlog.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IBlogService _blogService;

        public AuthorsController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult AuthorAbout(int id)
        {
            var authorDetails = _blogService.GetBlogById(id);
            return PartialView(authorDetails);
        }
        public PartialViewResult AuthorPopularPosts(int id)
        {
            var blogAuthor = _blogService.GetAll()
                .Where(b => b.Id == id)
                .Select(y => y.AuthorId).FirstOrDefault();
            var authorBlogs = _blogService.GetBlogByAuthor(blogAuthor);
            return PartialView(authorBlogs);
        }
    }
}