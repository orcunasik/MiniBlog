using MiniBlog.Business.Abstractions;
using PagedList;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;

namespace MiniBlog.MVC.Controllers
{
    public class BlogsController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        public BlogsController(IBlogService blogService, ICategoryService categoryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }

        public ActionResult Index(int? pageNo)
        {
            int _pageNo = pageNo ?? 1;
            var blogs = _blogService.GetAll().ToPagedList(_pageNo, 3);
            if (Request.IsAjaxRequest())
            {
                return PartialView("~/Views/Blogs/BlogList.cshtml", blogs);
            }
            return View(blogs);
        }
        public ActionResult BlogByCategory(int id)
        {
            var blogCategory = _blogService.GetBlogByCategory(id);
            string categoryName = _categoryService.GetById(id).Name;
            string categoryDescription = _categoryService.GetById(id).Description;
            ViewBag.blogCategoryName = categoryName;
            ViewBag.blogCategoryDescription = categoryDescription;
            return View(blogCategory);
        }
        public PartialViewResult FeaturedPosts()
        {
            #region Post1
                var postTitle1 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 1).Select(y => y.Title).FirstOrDefault();
                var postImage1 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 1).Select(y => y.Image).FirstOrDefault();
                var postDate1 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 1).Select(y => y.Date.ToString("MMMM dd yyyy")).FirstOrDefault();

                ViewBag.PostTitle1 = postTitle1;
                ViewBag.PostImage1 = postImage1;
                ViewBag.PostDate1 = postDate1;
            #endregion
            #region Post2
                var postTitle2 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 2).Select(y => y.Title).FirstOrDefault();
                var postImage2 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 2).Select(y => y.Image).FirstOrDefault();
                var postDate2 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 2).Select(y => y.Date.ToString("MMMM dd yyyy")).FirstOrDefault();

                ViewBag.PostTitle2 = postTitle2;
                ViewBag.PostImage2 = postImage2;
                ViewBag.PostDate2 = postDate2;
            #endregion
            #region Post3
                var postTitle3 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 3).Select(y => y.Title).FirstOrDefault();
                var postImage3 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 3).Select(y => y.Image).FirstOrDefault();
                var postDate3 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 3).Select(y => y.Date.ToString("MMMM dd yyyy")).FirstOrDefault();

                ViewBag.PostTitle3 = postTitle3;
                ViewBag.PostImage3 = postImage3;
                ViewBag.PostDate3 = postDate3;
            #endregion
            #region Post4
                var postTitle4 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 3).Select(y => y.Title).LastOrDefault();
                var postImage4 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 3).Select(y => y.Image).LastOrDefault();
                var postDate4 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 3).Select(y => y.Date.ToString("MMMM dd yyyy")).LastOrDefault();

                ViewBag.PostTitle4 = postTitle4;
                ViewBag.PostImage4 = postImage4;
                ViewBag.PostDate4 = postDate4;
            #endregion
            #region Post5
                var postTitle5 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 14).Select(y => y.Title).FirstOrDefault();
                var postImage5 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 14).Select(y => y.Image).FirstOrDefault();
                var postDate5 = _blogService.GetAll().OrderByDescending(o => o.Id).Where(c => c.CategoryId == 14).Select(y => y.Date.ToString("MMMM dd yyyy")).FirstOrDefault();

                ViewBag.PostTitle5 = postTitle5;
                ViewBag.PostImage5 = postImage5;
                ViewBag.PostDate5 = postDate5;
            #endregion


            return PartialView();
        }
        public PartialViewResult BlogList()
        {
            var blogs = _blogService.GetAll().ToList();
            return PartialView(blogs);
        }
        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }

        public ActionResult BlogDetails()
        {
            return View();
        }
        public PartialViewResult BlogCover(int id)
        {
            var result = _blogService.GetBlogById(id);
            return PartialView(result);
        }
        public PartialViewResult BlogReadMore(int id)
        {
            var result = _blogService.GetBlogById(id);
            return PartialView(result);
        }
    }
}