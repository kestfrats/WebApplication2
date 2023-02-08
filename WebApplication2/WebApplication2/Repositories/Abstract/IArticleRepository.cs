using WebApplication2.Areas.Blog.Data;
using static WebApplication2.Repositories.Abstract.IRepository;

namespace WebApplication2.Repositories.Abstract
{
    public interface IArticleRepository : IRepository<Article>
    {
    }
}
