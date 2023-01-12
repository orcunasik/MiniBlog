using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers
{
    public class AboutsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Footer()
        {
            return PartialView();
        }
        public PartialViewResult Team()
        {
            return PartialView();
        }
    }
}