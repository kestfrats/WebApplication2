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



}