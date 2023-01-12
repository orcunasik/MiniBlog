using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers
{
    public class AuthorsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult AuthorAbout()
        {
            return PartialView();
        }
        public PartialViewResult AuthorPopularPosts()
        {
            return PartialView();
        }
    }
}