using WebApplication2.Areas.Blog.Data;

namespace WebApplication2.Models.Partial
{
    public class CreateArticleVM
    {
        public string Headline { get; set; }
        public string Content { get; set; }
        public int ReadableTime { get; set; }

        public ICollection<Hashtag> Hashtags { get; set; }
    }
}
