using WebApplication2.Areas.Blog.Data;
using WebApplication2.Areas.Blog.Model;
using WebApplication2.Areas.Identity.Data;
using WebApplication2.Repositories.Concrete;
using WebApplication2.Services.Abstract;

namespace WebApplication2.Services.Concrete;

public class ArticleService : IArticleService
{
    private readonly GenericRepository<Article> _repository;

    public ArticleService(ApplicationDbContext dbContext)
    {
        _repository = new GenericRepository<Article>(dbContext);
    }

    public void Create(ArticleVM model)
    {
        Article article = new Article()
        {
            Headline = model.Headline,
            Content = model.Content,
            ReadableTime = model.ReadableTime,
            ArticleHashtags = model.Hashtags
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
}