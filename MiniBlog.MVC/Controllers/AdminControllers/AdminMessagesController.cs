using MiniBlog.Business.Abstractions;
using MiniBlog.Entities.Concretes;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers.AdminControllers
{
    public class AdminMessagesController : Controller
    {
        private readonly IContactService _contactService;

        public AdminMessagesController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public ActionResult SendBox()
        {
            IEnumerable<Contact> contacts = _contactService.GetAll();
            return View(contacts);
        }
        public ActionResult InBox()
        {
            IEnumerable<Contact> contacts = _contactService.GetAll();
            return View(contacts);
        }
        public PartialViewResult MessageSidebar()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult MessageDetails(int id)
        {
            Contact contact = _contactService.GetById(id);
            return View(contact);
        }
    }
}