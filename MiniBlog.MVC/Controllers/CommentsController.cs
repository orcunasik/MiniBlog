using MiniBlog.Business.Abstractions;
using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var comments = _commentService.GetCommentByBlog(id);
            return PartialView(comments);
        }

        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.entityId = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult LeaveComment(Comment comment)
        {

            comment.Date = DateTime.Now;
            _commentService.Add(comment);
            return PartialView();
        }
    }
}