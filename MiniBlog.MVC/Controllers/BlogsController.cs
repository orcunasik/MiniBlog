using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers
{
    public class BlogsController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BlogByCategory()
        {
            return View();
        }
        public PartialViewResult FeaturedPosts()
        {
            return PartialView();
        }
        public PartialViewResult BlogList()
        {
            return PartialView();
        }
        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }
        public PartialViewResult MailSubscribe()
        {
            return PartialView();
        }
        public ActionResult BlogDetails()
        {
            return View();
        }
        public PartialViewResult BlogCover()
        {
            return PartialView();
        }
        public PartialViewResult BlogReadMore()
        {
            return PartialView();
        }
    }
}