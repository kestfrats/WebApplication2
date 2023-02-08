using WebApplication2.Areas.Blog.Data;

namespace WebApplication2.Models.Partial
{
    public class ArticleVM
    {
        public string Headline { get; set; }
        public string Content { get; set; }
        public int ReadableTime { get; set; }

        public ICollection<ArticleHashtag> Hashtags { get; set; }
    }
}
