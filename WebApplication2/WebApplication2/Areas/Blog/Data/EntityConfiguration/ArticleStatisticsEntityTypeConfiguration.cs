using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication2.Areas.Blog.Data.EntityConfiguration
{
    public class ArticleStatisticsEntityTypeConfiguration : IEntityTypeConfiguration<ArticleStatistics>
    {
        public void Configure(EntityTypeBuilder<ArticleStatistics> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x=>x.ID).UseIdentityColumn();

            builder.Property(x=>x.Article).IsRequired();
            builder.Property(x=>x.ArticleID).IsRequired();
        }
    }
}
