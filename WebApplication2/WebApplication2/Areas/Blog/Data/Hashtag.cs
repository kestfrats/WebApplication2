using WebApplication2.Entities;

namespace WebApplication2.Areas.Blog.Data
{
    public class Hashtag : BaseEntity
    {
        public string Name { get; set; }


        //navigation

        public Hashtag()
        {
            ArticleHastags=new HashSet<ArticleHashtag>();
        }

        public virtual ICollection<ArticleHashtag> ArticleHastags { get; set; }
        public virtual HashtagStatistics HashtagStatistics { get; set; }
    }
}
