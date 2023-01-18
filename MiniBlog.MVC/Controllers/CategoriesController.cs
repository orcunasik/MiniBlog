using MiniBlog.Business.Abstractions;
using MiniBlog.Business.Concretes;
using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var categories = _categoryService.GetAll();
            return View(categories);
        }
        [HttpGet]
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Category category)
        {
            _categoryService.Add(category);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var categoryId = _categoryService.GetById(id);
            return View(categoryId);
        }
        [HttpPost]
        public ActionResult Update(Category category)
        {
            _categoryService.Update(category);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Remove(int id)
        {
            var categoryId = _categoryService.GetById(id);
            _categoryService.Remove(categoryId);
            return RedirectToAction(nameof(Index));
        }
        public PartialViewResult CategoryList()
        {
            var categories = _categoryService.GetAll();
            return PartialView(categories);
        }
    }
}