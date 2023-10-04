using Hurghada.Domain.Entities.Property;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurghada.Infrastructure.Configs.PropertyConfig
{
    public class PropertyConfigs : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.ToTable("Properties", "Property");
            builder.HasMany(p => p.PropertyAmenities)
                .WithOne(pa => pa.Property)
                .HasForeignKey(pa => pa.PropertyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.PropertyType)
                .WithMany(pt => pt.Properties)
                .HasForeignKey(p => p.PropertyTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
