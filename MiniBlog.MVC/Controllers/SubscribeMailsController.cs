using MiniBlog.Business.Abstractions;
using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers
{
    public class SubscribeMailsController : Controller
    {
        private readonly ISubscribeMailService _subscribeMailService;

        public SubscribeMailsController(ISubscribeMailService subscribeMailService)
        {
            _subscribeMailService = subscribeMailService;
        }

        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult AddMail(SubscribeMail subscribeMail)
        {
            _subscribeMailService.Add(subscribeMail);
            return RedirectToAction("Index", "Blogs");
        }

    }
}