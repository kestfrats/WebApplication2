using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication2.Areas.Blog.Data.EntityConfiguration
{
    public class HashtagEntityTypeConfiguration : IEntityTypeConfiguration<Hashtag>
    {
        public void Configure(EntityTypeBuilder<Hashtag> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.HasIndex(x=>x.Name).IsUnique();
            builder.HasMany(x => x.Articles).WithMany(x => x.Hashtags);
        }
    }
}
