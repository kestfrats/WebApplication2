using WebApplication2.Areas.Blog.Data;
using WebApplication2.Areas.Identity.Data;

namespace WebApplication2.Repositories.Concrete
{
    public class ArticleRepository : GenericRepository<Article>
    {
        private readonly ApplicationDbContext db;

        public ArticleRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
