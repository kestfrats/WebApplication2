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

        public List<Hashtag> ProcessHashtags(string HashtagString)
        {
            var hashtagList = HashtagString.Replace(" ", "").Split('#');
            var result = new List<Hashtag>();
            foreach (var tag in hashtagList)
            {
                var hashtag = FindByName(tag);
                if (hashtag != null)
                {
                    result.Add(hashtag);
                }
                else
                {
                    result.Add(Create(new Hashtag()
                    {
                        Name = tag
                    }));
                }
            }

            return result;
        }


        public Hashtag Create(Hashtag hashtag)
        {
            if (!hashtagRepository.Add(hashtag))
            {
                throw new Exception("Hashtag cannot be saved");
            }

            return hashtag;
        }

        public Hashtag FindByName(string searchQuery)
        {
            var result = hashtagRepository.GetAll().Where(_ => _.Name.Equals(searchQuery)).FirstOrDefault();

            return result;
        }
    }
}