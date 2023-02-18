using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Areas.Blog.Model;
using WebApplication2.Areas.Identity.Data;
using WebApplication2.Services.Abstract;

namespace WebApplication2.Areas.Blog.Controllers;


public class ArticleController : HomeController
{

    private readonly IArticleService articleService;
        
    public ArticleController(IArticleService articleService)
    {
        this.articleService = articleService;
    }

    public IActionResult Index()
    {
        var vm = articleService.GetAll();
        return View(vm);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(ArticleVM model)
    {
        if(!ModelState.IsValid)
        {
            return Json("fail");
        }
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
    
}