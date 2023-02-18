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
        Article article = new Article()
        {
            Headline = model.Headline,
            Content = model.Content,
            ReadableTime = model.ReadableTime,
            ArticleHashtags = model.Hashtags
        };
        _repository.Update(article);
    }

    public void Delete(ArticleVM model)
    {
        Article article = new Article()
        {
            Headline = model.Headline,
            Content = model.Content,
            ReadableTime = model.ReadableTime,
            ArticleHashtags = model.Hashtags
        };
        _repository.Delete(article);
    }

    public List<ArticleVM> GetAll()
    {
        var user = _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);
        return _repository.GetAll().Where(x => x.User.Id == user.Result.Id).Select(x => new ArticleVM {
            Content = x.Content,
            ReadableTime = x.ReadableTime,
            Headline = x.Headline,
            Hashtags = x.ArticleHashtags,
            Id=x.ID,
        }).ToList();
        
       
    }
}