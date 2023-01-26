using MiniBlog.Business.Abstractions;
using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers.AdminControllers
{
    public class AdminBlogsController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly IAuthorService _authorService;

        public AdminBlogsController(IBlogService blogService, ICategoryService categoryService, IAuthorService authorService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
            _authorService = authorService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Blogs()
        {
            var blogList = _blogService.GetAll();
            return View(blogList);
        }

        public ActionResult BlogDetail(int id)
        {
            var blogDetail = _blogService.GetById(id);
            return View(blogDetail);
        }

        [HttpGet]
        public ActionResult Save()
        {
            List<SelectListItem> categories = new List<SelectListItem>
                    (from c in _categoryService.GetAll()
                    select new SelectListItem
                    {
                        Text = c.Name,
                        Value = c.Id.ToString()
                    });
            ViewBag.CategoryList = categories;

            List<SelectListItem> auhors = new List<SelectListItem>
                    (from a in _authorService.GetAll()
                     select new SelectListItem
                     {
                        Text = a.Name,
                        Value = a.Id.ToString()
                     });
            ViewBag.AuthorList = auhors;
            return View();
        }
        [HttpPost]
        public ActionResult Save(Blog blog)
        {
            blog.IsActive = true;
            blog.Date = DateTime.Now;
            _blogService.Add(blog);
            return RedirectToAction(nameof(Blogs));
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var blogId = _blogService.GetById(id);
            List<SelectListItem> categories = new List<SelectListItem>(
                    from c in _categoryService.GetAll()
                    select new SelectListItem
                    {
                        Text = c.Name,
                        Value = c.Id.ToString(),
                        Selected = c.Id == blogId.CategoryId
                    });
            ViewBag.CategoryList = categories;

            List<SelectListItem> authors = new List<SelectListItem>(
                    from a in _authorService.GetAll()
                    select new SelectListItem
                    {
                        Text = a.Name,
                        Value = a.Id.ToString(),
                        Selected = a.Id == blogId.AuthorId
                    });
            ViewBag.AuthorList = authors;
            return View(blogId);
        }
        [HttpPost]
        public ActionResult Update(Blog blog)
        {
            _blogService.Update(blog);
            return RedirectToAction(nameof(Blogs));
        }
        
        public ActionResult Remove(int id)
        {
            var blogId = _blogService.GetById(id);
            _blogService.Remove(blogId);
            return RedirectToAction(nameof(Blogs));
        }
    }
}