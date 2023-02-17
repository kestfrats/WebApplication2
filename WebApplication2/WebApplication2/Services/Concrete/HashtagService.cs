using WebApplication2.Areas.Blog.Data;
using WebApplication2.Areas.Identity.Data;
using WebApplication2.Models.Partial;
using WebApplication2.Repositories.Abstract;
using WebApplication2.Services.Abstract;

namespace WebApplication2.Services.Concrete
{
    public class HashtagService : IHashtagService
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IHashtagRepository hashtagRepository;

        public HashtagService(ApplicationDbContext applicationDbContext,IHashtagRepository hashtagRepository)
        {
            this.applicationDbContext = applicationDbContext;
            this.hashtagRepository = hashtagRepository;
        }
        public void Create(HashtagVM model)
        {
            Hashtag hashtag = new Hashtag()
            {
                Name = model.Name,
                ArticleHastags=model.Articles
            };
            hashtagRepository.Add(hashtag);
            
        }

        public void Delete(HashtagVM model)
        {
            Hashtag hashtag = new Hashtag()
            {
                Name = model.Name,
                ArticleHastags = model.Articles
            };
            hashtagRepository.Update(hashtag);
        }

        public void Update(HashtagVM model)
        {
            Hashtag hashtag = new Hashtag()
            {
                Name = model.Name,
                ArticleHastags = model.Articles
            };
            hashtagRepository.Update(hashtag);
        }
    }
}
