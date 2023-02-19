using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models.Partial;
using WebApplication2.Services.Abstract;

namespace WebApplication2.Areas.Blog.Controllers;

public class HashtagController : HomeController
{
    private readonly IHashtagService _hashtagService;


    public HashtagController(IHashtagService hashtagService)
    {
        _hashtagService = hashtagService;
    }

    [HttpPost]
    public JsonResult Create(HashtagVM model)
    {
        model = _hashtagService.Create(model);
        return Json(model);
    }

    [HttpGet]
    public List<HashtagVM> SearchByName(string searchQuery)
    {
        return _hashtagService.SearchByName(searchQuery);
    }

}