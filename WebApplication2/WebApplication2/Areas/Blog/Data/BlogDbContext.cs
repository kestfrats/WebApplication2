using Microsoft.EntityFrameworkCore;
using WebApplication2.Areas.Blog.Data.EntityConfiguration;

namespace WebApplication2.Areas.Blog.Data
{
    public class BlogDbContext:DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleHashtag> ArticleHashtags { get; set; }
        public DbSet<ArticleStatistics> ArticleStatistics { get; set; }
        public DbSet<Hashtag> Hashtags { get; set; }
        public DbSet<HashtagStatistics> HashtagsStatistics { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleEntityTypeConfiguration())
                        .ApplyConfiguration(new ArticleHashtagEntityTypeConfiguration())
                        .ApplyConfiguration(new ArticleStatisticsEntityTypeConfiguration())
                        .ApplyConfiguration(new HashtagEntityTypeConfiguration())
                        .ApplyConfiguration(new HashtagStatisticsEntityTypeConfiguration());

        }
    }
}
