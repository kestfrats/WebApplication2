using Microsoft.AspNetCore.Mvc;
using WebApplication2.Areas.Blog.Repositories.Abstract;

namespace WebApplication2.Areas.Blog.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleRepository articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }
        public IActionResult CreateArticle()
        {
            return PartialView("");
        }
    }
}
