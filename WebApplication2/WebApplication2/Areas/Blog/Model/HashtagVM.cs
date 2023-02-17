using WebApplication2.Areas.Blog.Data;

namespace WebApplication2.Models.Partial
{
    public class HashtagVM
    {
        public string Name { get; set; }
        public ICollection<ArticleHashtag> Articles { get; set; }
    }
}
