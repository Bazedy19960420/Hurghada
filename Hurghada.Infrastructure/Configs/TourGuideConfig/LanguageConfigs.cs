using Hurghada.Domain.Entities.TourGuide;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurghada.Infrastructure.Configs.TourGuideConfig
{
    public class LanguageConfigs : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages", "TourGuide");
            builder.HasMany(l => l.GuideLanguages)
                .WithOne(gl => gl.Language)
                .HasForeignKey(gl => gl.LanguageId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(new List<Language>()
            {
                new Language() {Id = 1, Name = "English"},
                new Language() {Id = 2, Name = "German"},
                new Language() {Id = 3, Name = "French"},
                new Language() {Id = 4, Name = "Italian"},
                new Language() {Id = 5, Name = "Spanish"},
                new Language() {Id = 6, Name = "Russian"},
            });

        }
    }
}
