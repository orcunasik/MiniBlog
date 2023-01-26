using MiniBlog.Business.Abstractions;
using MiniBlog.Entities.Concretes;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers.AdminControllers
{
    public class AdminAboutsController : Controller
    {
        private readonly IAboutService _aboutService;

        public AdminAboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<About> abouts = _aboutService.GetAll();
            return View(abouts);
        }

        [HttpPost]
        public ActionResult Update(About about)
        {
            _aboutService.Update(about);
            return RedirectToAction(nameof(Index));
        }
    }
}