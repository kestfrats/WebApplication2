using WebApplication2.Areas.Blog.Data;
using static WebApplication2.Areas.Blog.Repositories.Abstract.IRepository;

namespace WebApplication2.Areas.Blog.Repositories.Abstract
{
    public interface IArticleRepository:IRepository<Article>
    {
    }
}
