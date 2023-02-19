using MiniBlog.Business.Abstractions;
using MiniBlog.Business.Concretes;
using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers.AuthorControllers
{
    public class AuthorBlogsController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IAuthorService _authorService;
        private readonly ICategoryService _categoryService;

        public AuthorBlogsController(IBlogService blogService, IAuthorService authorService, ICategoryService categoryService)
        {
            _blogService = blogService;
            _authorService = authorService;
            _categoryService = categoryService;
        }
        public ActionResult Blogs(string email)
        {
            email = (string)Session["Email"];
            int id = _authorService.Where(i => i.Email == email).Select(x => x.Id).FirstOrDefault();
            var blogs = _blogService.GetBlogByAuthor(id);
            return View(blogs);
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
    }
}