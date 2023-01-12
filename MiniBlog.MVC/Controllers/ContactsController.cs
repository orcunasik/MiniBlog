using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers
{
    public class ContactsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ContactForm()
        {
            return PartialView();
        }
        public PartialViewResult ContactAddress()
        {
            return PartialView();
        }
    }
}