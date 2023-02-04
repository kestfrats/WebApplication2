using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication2.Areas.Blog.Data.EntityConfiguration
{
    public class HashtagStatisticsEntityTypeConfiguration : IEntityTypeConfiguration<HashtagStatistics>
    {
        public void Configure(EntityTypeBuilder<HashtagStatistics> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();

        }
    }
}
