using WebApplication2.Areas.Identity.Data;
using WebApplication2.Entities;

namespace WebApplication2.Areas.Blog.Data
{
    public class Article : BaseEntity
    {
        public string Headline { get; set; }
        public string Content { get; set; }
        public int ReadableTime { get; set; }

        //navigation
        public string UserID { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ArticleStatistics ArticleStatistics { get; set; }

        public Article()
        {
            ArticleHashtags=new HashSet<ArticleHashtag>();
        }

        public virtual ICollection<ArticleHashtag> ArticleHashtags { get; set;}
    }
}
