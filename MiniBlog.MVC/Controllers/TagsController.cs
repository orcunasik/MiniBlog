using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers
{
    public class TagsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult TagCloud()
        {
            return PartialView();
        }
    }
}