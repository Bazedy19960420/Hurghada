using Hurghada.Domain.Entities.Property;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurghada.Infrastructure.Configs
{
    public class PropertyTypeConfigs : IEntityTypeConfiguration<PropertyType>
    {
        public void Configure(EntityTypeBuilder<PropertyType> builder)
        {
            builder.ToTable("PropertyTypes", "Property");
            builder.HasMany(pt => pt.Properties)
                .WithOne(p => p.PropertyType)
                .HasForeignKey(p => p.PropertyTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(new List<PropertyType>
            {
                new PropertyType{Id=1,Name = "Apartment"},
                new PropertyType{Id=2,Name = "Villa"},
                new PropertyType{Id=3,Name = "Chalet"},
                new PropertyType{Id=4,Name = "Studio"},
                new PropertyType{Id=5,Name = "Duplex"},
                new PropertyType{Id=6,Name = "Penthouse"},
                new PropertyType{Id=7,Name = "Townhouse"},
                new PropertyType{Id=8,Name = "Twin House"},
                new PropertyType{Id=9,Name = "Cabin"},
                new PropertyType{Id=10,Name = "Building"},
                new PropertyType{Id=11,Name = "Farm House"},
                new PropertyType{Id=12,Name="Chalet"},
                new PropertyType{Id=13,Name="Hotel"},
                new PropertyType{Id=14,Name="Resort"},
                new PropertyType{Id=15,Name="House"},
                new PropertyType{Id=16,Name="Flat"},
            });
        }
    }
}
