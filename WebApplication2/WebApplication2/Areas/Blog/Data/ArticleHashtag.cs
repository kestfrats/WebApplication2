using WebApplication2.Entities;

namespace WebApplication2.Areas.Blog.Data
{
    public class ArticleHashtag:BaseEntity
    {

        //navigation
        public int ArticleID { get; set; }
        public virtual Article Article { get; set; }

        public int HashtagID { get; set; }
        public virtual Hashtag Hashtag { get; set; }
    }
}
