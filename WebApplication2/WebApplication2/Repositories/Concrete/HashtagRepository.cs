using WebApplication2.Areas.Blog.Data;
using WebApplication2.Areas.Identity.Data;
using WebApplication2.Repositories.Abstract;

namespace WebApplication2.Repositories.Concrete
{
    public class HashtagRepository : GenericRepository<Hashtag>, IHashtagRepository
    {
        private readonly ApplicationDbContext db;

        public HashtagRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
