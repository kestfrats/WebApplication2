﻿using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Areas.Blog.Data;
using WebApplication2.Areas.Blog.Model;
using WebApplication2.Areas.Identity.Data;
using WebApplication2.Repositories.Concrete;
using WebApplication2.Services.Abstract;


namespace WebApplication2.Services.Concrete;

public class ArticleService : IArticleService
{
    private readonly GenericRepository<Article> _repository;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IHashtagService _hashtagService;


    public ArticleService(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager,
        IHttpContextAccessor httpContextAccessor, IHashtagService hashtagService)
    {
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
        _hashtagService = hashtagService;
        _repository = new GenericRepository<Article>(dbContext);
    }

    public void Create(ArticleVM model)
    {
        var user = _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);

        Article article = new Article()
        {
            Headline = model.Headline,
            Content = model.Content,
            ReadableTime = model.ReadableTime,
            User = user.Result
        };

        var hashtags = _hashtagService.ProcessHashtags(model.HashtagString);

        article.Hashtags = hashtags;

        article.ArticleStatistics = new ArticleStatistics()
        {
            UpdateDate = DateTime.Now,
            LoveYou = 1,
            NumberOfClicks = 1,
            CreationDate = DateTime.Now,
        };

        _repository.Add(article);
    }

    public void Update(ArticleVM model)
    {
        var a = _repository.GetAll().Where(_ => _.ID == model.Id).Include(_ => _.Hashtags).FirstOrDefault();
        a.Headline = model.Headline;
        a.Content = model.Content;
        a.ReadableTime = model.ReadableTime;
        
        
        var hashtags = _hashtagService.ProcessHashtags(model.HashtagString);
        a.Hashtags = hashtags;
        _repository.Update(a);
    }

    public void Delete(int id)
    {
        var a = _repository.GetById(id);
        _repository.Delete(a);
    }

    public List<ArticleVM> GetAll(bool userfilter)
    {
        List<Article> list;
        if (userfilter)
        {
            var user = _userManager.GetUserId(_httpContextAccessor.HttpContext?.User);

            list = _repository.GetWhere(x => x.UserID == user).Include(_ => _.Hashtags).ToList();
        }
        else
        {
            list = _repository.GetAll().ToList();
        }

        var resultList = new List<ArticleVM>();
        foreach (var a in list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var tag in a.Hashtags)
            {
                sb.Append($"#{tag.Name} ");
            }

            resultList.Add(new ArticleVM()
            {
                Id = a.ID,
                Content = a.Content,
                Headline = a.Headline,
                ReadableTime = a.ReadableTime,
                HashtagString = sb.ToString()
            });
        }
        
        return resultList;
    }

    public ArticleVM GetById(int Id)
    {
        var x = _repository.GetAll().Where(_ => _.ID == Id).Include(_ => _.Hashtags).FirstOrDefault();
        ArticleVM articleVM = new ArticleVM
        {
            Content = x.Content,
            ReadableTime = x.ReadableTime,
            Headline = x.Headline,
            Id = x.ID,
        };
        
        StringBuilder sb = new StringBuilder();
        foreach (var tag in x.Hashtags)
        {
            sb.Append($"#{tag.Name} ");
        }

        articleVM.HashtagString = sb.ToString();
        return articleVM;
    }
}