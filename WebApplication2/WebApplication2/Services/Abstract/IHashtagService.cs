using WebApplication2.Areas.Blog.Data;
using WebApplication2.Models.Partial;

namespace WebApplication2.Services.Abstract
{
    public interface IHashtagService
    {
        public List<Hashtag> ProcessHashtags(string HashtagString);
        public Hashtag Create(Hashtag hashtag);
        public Hashtag FindByName(string searchQuery);

        public Hashtag GetById(int id);
        public List<HashtagVM> GetHashtag();
        public List<Hashtag> GetAll();
    }
}