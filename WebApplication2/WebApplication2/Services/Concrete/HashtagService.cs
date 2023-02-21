using Microsoft.EntityFrameworkCore;
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
                if (tag != "")
                {
                    var hashtag = FindByName(tag.ToLower());
                    if (hashtag != null)
                    {
                        result.Add(hashtag);
                    }
                    else
                    {
                        result.Add(Create(new Hashtag()
                        {
                            Name = tag.ToLower()
                        }));
                    }
                }
            }

            return result;
        }


        public Hashtag Create(Hashtag hashtag)
        {
            hashtag.HashtagStatistics = new HashtagStatistics
            {
                Hashtag = hashtag,
                NumberOfClicks = 1
            };
            if (!hashtagRepository.Add(hashtag))
            {
                throw new Exception("Hashtag cannot be saved");
            }

            return hashtag;
        }

        public Hashtag GetById(int id)
        {
            var result = hashtagRepository.GetAll().Where(_ => _.ID == id).Include(_ => _.Articles)
                .ThenInclude(_ => _.User).FirstOrDefault();
            return result;
        }

        public Hashtag FindByName(string searchQuery)
        {
            var result = hashtagRepository.GetAll().Where(_ => _.Name.Equals(searchQuery)).FirstOrDefault();

            return result;
        }

        public List<HashtagVM> GetHashtag()
        {
            var list = hashtagRepository.GetAll().Include(_ => _.HashtagStatistics)
                .OrderByDescending(_ => _.HashtagStatistics.NumberOfClicks).Take(10).ToList();
            var resultList = new List<HashtagVM>();

            foreach (var item in list)
            {
                resultList.Add(new HashtagVM()
                {
                    Id = item.ID,
                    Name = item.Name
                });
            }

            return resultList;
        }

        public List<Hashtag> GetAll()
        {
            var result = hashtagRepository.GetAll().Include(_ => _.Articles).ToList();
            return result;
        }
    }
}