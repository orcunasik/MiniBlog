using MiniBlog.Business.Abstractions;
using MiniBlog.DataAccess.Concretes.EntityFramework.Contexts;
using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Web;
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
        public ActionResult AdminBlogsList()
        {
            var blogList = _blogService.GetAll();
            return View(blogList);
        }
        [HttpGet]
        public ActionResult Save()
        {
            List<SelectListItem> categoryValues = (from c in _categoryService.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = c.Name,
                                                       Value = c.Id.ToString()
                                                   }).ToList();
            ViewBag.categoryValues = categoryValues;

            List<SelectListItem> authorValues = (from a in _authorService.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = a.Name,
                                                       Value = a.Id.ToString()
                                                   }).ToList();
            ViewBag.authorValues = authorValues;
            return View();
        }
        [HttpPost]
        public ActionResult Save(Blog blog)
        {
            blog.Date = DateTime.Now;
            _blogService.Add(blog);
            return RedirectToAction(nameof(AdminBlogsList));
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            //var blogId = _blogService.Find(i => i.Id == id);
            var blogId = _blogService.GetById(id);
            List<SelectListItem> categoryValues = (from c in _categoryService.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = c.Name,
                                                       Value = c.Id.ToString()
                                                   }).ToList();
            ViewBag.categoryValues = categoryValues;

            List<SelectListItem> authorValues = (from a in _authorService.GetAll()
                                                 select new SelectListItem
                                                 {
                                                     Text = a.Name,
                                                     Value = a.Id.ToString()
                                                 }).ToList();
            ViewBag.authorValues = authorValues;
            return View(blogId);
        }
        [HttpPost]
        public ActionResult Update(Blog blog)
        {
            _blogService.Update(blog);
            return RedirectToAction(nameof(AdminBlogsList));
        }
        
        public ActionResult Remove(int id)
        {
            var blogId = _blogService.GetById(id);
            _blogService.Remove(blogId);
            return RedirectToAction(nameof(AdminBlogsList));
        }
    }
}