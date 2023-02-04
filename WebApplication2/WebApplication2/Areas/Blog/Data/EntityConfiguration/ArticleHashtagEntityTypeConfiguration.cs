using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication2.Areas.Blog.Data.EntityConfiguration
{
    public class ArticleHashtagEntityTypeConfiguration : IEntityTypeConfiguration<ArticleHashtag>
    {
        public void Configure(EntityTypeBuilder<ArticleHashtag> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.HasOne(x=>x.Article).WithMany(x=>x.ArticleHashtags).HasForeignKey(x=>x.ArticleID);
            builder.HasOne(x => x.Hashtag).WithMany(x => x.ArticleHastags).HasForeignKey(x => x.HashtagID);
        }
    }
}
