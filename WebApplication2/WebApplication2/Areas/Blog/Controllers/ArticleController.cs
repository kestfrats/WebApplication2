using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Areas.Blog.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
