using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication2.Areas.Blog.Data.EntityConfiguration
{
    public class ArticleEntityTypeConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x=>x.ID).UseIdentityColumn();
            builder.HasOne(x => x.User).WithMany(x => x.Articles).HasForeignKey(x=>x.UserID);
            builder.HasMany(x => x.Hashtags).WithMany(x => x.Articles);


        }
    }
}
