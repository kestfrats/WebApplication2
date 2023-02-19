using WebApplication2.Entities;

namespace WebApplication2.Areas.Blog.Data
{
    public class Hashtag : BaseEntity
    {
        public string Name { get; set; }


        //navigation

        public Hashtag()
        {
            Articles = new HashSet<Article>();
        }

        public virtual ICollection<Article> Articles { get; set; }
        public virtual HashtagStatistics HashtagStatistics { get; set; }
    }
}