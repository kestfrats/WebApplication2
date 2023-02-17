using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models.Partial;
using WebApplication2.Repositories.Abstract;
using WebApplication2.Services.Abstract;

namespace WebApplication2.Areas.Blog.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;

        public ArticleController(IArticleService articleService)
        {
            this.articleService = articleService;
        }
        public IActionResult Create(ArticleVM model)
        {
            articleService.Create(model);

            return View();
           
        }
        public IActionResult Update(ArticleVM model)
        {
            articleService.Update(model);

            return View();

        }
        public IActionResult Delete(ArticleVM model)
        {
            articleService.Delete(model);

            return View();

        }
        public IActionResult CreateArticle()
        {
            return PartialView("Partial/_CreateArticlePartial");
        }
    }
}
