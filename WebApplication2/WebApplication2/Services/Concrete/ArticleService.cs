using WebApplication2.Areas.Blog.Data;
using WebApplication2.Models.Partial;
using WebApplication2.Repositories.Abstract;
using WebApplication2.Services.Abstract;

namespace WebApplication2.Services.Concrete
{
    public class ArticleService:IArticleService
    {
        private readonly IArticleRepository articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
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
            articleRepository.Add(article);

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
            articleRepository.Update(article);
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
            articleRepository.Delete(article);
        }
    }
}
