using Microsoft.AspNetCore.Identity;
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


    public ArticleService(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
    {
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
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
            ArticleHashtags = model.Hashtags,
            User = user.Result
        };
        _repository.Add(article);
    }

    public void Update(ArticleVM model)
    {
       var a=_repository.GetById(model.Id); 
        a.Headline = model.Headline;
        a.Content = model.Content;
        a.ReadableTime = model.ReadableTime;
        a.ArticleHashtags = model.Hashtags;
        _repository.Update(a);
    }

    public void Delete(int id)
    {
       var a= _repository.GetById(id);
        _repository.Delete(a);
    }

    public List<ArticleVM> GetAll(bool userfilter)
    {
        List<ArticleVM> list;
        if (userfilter)
        {
            var user = _userManager.GetUserId(_httpContextAccessor.HttpContext?.User);

            list = _repository.GetAll().Where(x => x.UserID == user).Select(x => new ArticleVM
            {
                Content = x.Content,
                ReadableTime = x.ReadableTime,
                Headline = x.Headline,
                Hashtags = x.ArticleHashtags,
                Id = x.ID,
            }).ToList();
        }
        else
        {
            list = _repository.GetAll().Select(x => new ArticleVM
            {
                Content = x.Content,
                ReadableTime = x.ReadableTime,
                Headline = x.Headline,
                Hashtags = x.ArticleHashtags,
                Id = x.ID,
            }).ToList();
        }
        
        

        return list;
    }

    public ArticleVM GetById(int Id)
    {
        var x=_repository.GetById(Id);
        ArticleVM articleVM = new ArticleVM
        {
            Content = x.Content,
            ReadableTime = x.ReadableTime,
            Headline = x.Headline,
            Hashtags = x.ArticleHashtags,
            Id = x.ID,
        };
        
        return articleVM;
    }

   
}