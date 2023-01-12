using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers
{
    public class CommentsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult CommentList()
        {
            return PartialView();
        }
        public PartialViewResult LeaveComment()
        {
            return PartialView();
        }
    }
}