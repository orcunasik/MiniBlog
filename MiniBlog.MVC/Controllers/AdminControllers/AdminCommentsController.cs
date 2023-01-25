using MiniBlog.Business.Abstractions;
using System.Web.Mvc;

namespace MiniBlog.MVC.Controllers.AdminControllers
{
    public class AdminCommentsController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IAuthorService _authorService;

        public AdminCommentsController(ICommentService commentService, IAuthorService authorService)
        {
            _commentService = commentService;
            _authorService = authorService;
        }

        public ActionResult Index()
        {
            var comments = _commentService.GetAll();
            return View(comments);
        }
        public ActionResult BlogComments(int id)
        {
            var blogComments = _commentService.GetCommentByBlog(id);
            return View(blogComments);
        }
        public PartialViewResult Comments()
        {
            var comments = _commentService.GetAll();
            return PartialView(comments);
        }
        public ActionResult CommentStatusChangeFalse(int id)
        {
            _commentService.CommentStatusToChange(id);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult CommentStatusChangeTrue(int id)
        {
            _commentService.CommentStatusToChange(id);
            return RedirectToAction(nameof(Index));
        }
    }
}