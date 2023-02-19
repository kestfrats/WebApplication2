using WebApplication2.Models.Partial;

namespace WebApplication2.Services.Abstract
{
    public interface IHashtagService
    {
        public List<HashtagVM> SplitHashtags(string HashtagString);
        public HashtagVM Create(HashtagVM model);
        public List<HashtagVM> SearchByName(string searchQuery);
    }
}
