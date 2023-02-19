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

        public HashtagService(ApplicationDbContext applicationDbContext, IHashtagRepository hashtagRepository)
        {
            this.applicationDbContext = applicationDbContext;
            this.hashtagRepository = hashtagRepository;
        }

        public List<Hashtag> SplitHashtags(string HashtagString)
        {
            var hashtagList = HashtagString.Replace(" ", "").Split('#');
            var result = new List<Hashtag>();
            foreach (var tag in hashtagList)
            {
                result.Add(new Hashtag()
                {
                    Name = tag
                });
            }
            return result;
        }
        
        
        
        public HashtagVM Create(HashtagVM model)
        {
            var hashtag = new Hashtag()
            {
                Name = model.Name
            };

            if (hashtagRepository.Add(hashtag))
            {
                model.Id = hashtag.ID;
            }
            else
            {
                throw new Exception("Hashtag cannot be saved");
            }

            return model;
        }

        public List<HashtagVM> SearchByName(string searchQuery)
        {
            var result = hashtagRepository.GetAll().Where(_ => _.Name.Contains(searchQuery)).Select(_ => new HashtagVM()
                {
                    Id   = _.ID,
                    Name = _.Name
                }
            ).ToList();
            
            return result;
        }
    }
}