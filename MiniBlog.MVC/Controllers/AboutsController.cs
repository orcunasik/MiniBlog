using MiniBlog.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers
{
    public class AboutsController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IAuthorService _authorService;

        public AboutsController(IAboutService aboutService, IAuthorService authorService)
        {
            _aboutService = aboutService;
            _authorService = authorService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult AboutContent()
        {
            var aboutContent = _aboutService.GetAll();
            return PartialView(aboutContent);
        }
        public PartialViewResult Footer()
        {
            var result = _aboutService.GetAll().ToList();
            return PartialView(result);
        }
        public PartialViewResult Team()
        {
            var teamList = _authorService.GetAll();
            return PartialView(teamList);
        }
    }
}