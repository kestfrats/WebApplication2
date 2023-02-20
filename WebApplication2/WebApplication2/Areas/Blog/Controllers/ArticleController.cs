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
        var vm = articleService.GetAll(true);
        return View(vm);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    public IActionResult Create(ArticleVM model)
    {
        //if (!ModelState.IsValid)
        //{
        //    return View(model);
        //}
        articleService.Create(model);
        
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult Update(int Id)
    {
        return View(articleService.GetById(Id));
    }
    [HttpPost]
    public IActionResult Update(ArticleVM model)
    {
        articleService.Update(model);

        return RedirectToAction("Index");

    }
    [HttpGet]
    public IActionResult Delete(int id)
    {
        articleService.Delete(id);

        return RedirectToAction("Index");

    }

    public IActionResult Timeline()
    {
        var vm = articleService.GetAll(false);
        return PartialView("Partial/Timeline",vm);

    }
    
}