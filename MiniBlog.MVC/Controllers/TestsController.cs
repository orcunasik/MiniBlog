using MiniBlog.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers
{
    public class TestsController : Controller
    {
        private readonly ICategoryService _service;

        public TestsController(ICategoryService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var categoryList = _service.GetAll().ToList();
            return View(categoryList);
        }
    }
}