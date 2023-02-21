using WebApplication2.Entities;

namespace WebApplication2.Areas.Blog.Data
{
    public class HashtagStatistics : BaseEntity
    {
        public int NumberOfClicks { get; set; }

        //navigation
        public int HashtagID { get; set; }
        public virtual Hashtag Hashtag { get; set; }
    }
}