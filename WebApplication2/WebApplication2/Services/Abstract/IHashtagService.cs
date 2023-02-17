using WebApplication2.Models.Partial;

namespace WebApplication2.Services.Abstract
{
    public interface IHashtagService
    {
        public void Create(HashtagVM model);
        public void Update(HashtagVM model);
        public void Delete(HashtagVM model);
    }
}
