using MiniBlog.Business.Abstractions;
using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ContactForm()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult ContactForm(Contact contact)
        {
            _contactService.Add(contact);
            return RedirectToAction(nameof(Index));
        }
        public PartialViewResult ContactAddress()
        {
            return PartialView();
        }
    }
}