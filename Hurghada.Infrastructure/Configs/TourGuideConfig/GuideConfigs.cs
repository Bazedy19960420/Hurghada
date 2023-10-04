using Hurghada.Domain.Entities.TourGuide;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurghada.Infrastructure.Configs.TourGuideConfig
{
    public class GuideConfigs : IEntityTypeConfiguration<Guide>
    {
        public void Configure(EntityTypeBuilder<Guide> builder)
        {
            builder.ToTable("Guides", "TourGuide");
            builder.HasMany(g => g.GuideLanguages)
                .WithOne(gl => gl.Guide)
                .HasForeignKey(gl => gl.GuideId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
