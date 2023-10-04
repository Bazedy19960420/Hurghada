using Hurghada.Domain.Entities.TourGuide;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurghada.Infrastructure.Configs.TourGuideConfig
{
    public class GuideLanguageConfigs : IEntityTypeConfiguration<GuideLanguage>
    {
        public void Configure(EntityTypeBuilder<GuideLanguage> builder)
        {
            builder.ToTable("GuideLanguages", "TourGuide");
            builder.HasKey(gl => new { gl.GuideId, gl.LanguageId });
            builder.HasOne(gl => gl.Guide)
                .WithMany(g => g.GuideLanguages)
                .HasForeignKey(gl => gl.GuideId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(gl => gl.Language)
                .WithMany(l => l.GuideLanguages)
                .HasForeignKey(gl => gl.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
