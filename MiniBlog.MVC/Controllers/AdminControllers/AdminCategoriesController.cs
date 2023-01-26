using MiniBlog.Business.Abstractions;
using MiniBlog.Entities.Concretes;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers.AdminControllers
{
    public class AdminCategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public AdminCategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            IEnumerable<Category> categories = _categoryService.GetAll();
            return View(categories);
        }
    }
}