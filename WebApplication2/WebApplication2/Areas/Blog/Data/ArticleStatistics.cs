using WebApplication2.Entities;

namespace WebApplication2.Areas.Blog.Data
{
    public class ArticleStatistics : BaseEntity
    {
        public int NumberOfClicks { get; set; }
        public int OrginalClicks { get; set; }
        public int LoveYou { get; set; }

        //navigation

        public int ArticleID { get; set; }
        public virtual Article Article { get; set; }
    }
}
