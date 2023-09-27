using Hurghada.Domain.Entities.Property;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurghada.Infrastructure.Configs
{
    public class AmenityConfigs : IEntityTypeConfiguration<Amenity>
    {
        public void Configure(EntityTypeBuilder<Amenity> builder)
        {
            builder.ToTable("Amenities", "Property");
            builder.HasMany(a => a.PropertyAmenities)
                .WithOne(pa => pa.Amenity)
                .HasForeignKey(pa => pa.AmenityId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(new List<Amenity>
            {
                new Amenity { Id = 1, Name = "Air conditioning" },
                new Amenity { Id = 2, Name = "Balcony" },
                new Amenity { Id = 4, Name = "Cable TV" },
                new Amenity { Id = 5, Name = "Cleaning after exit" },
                new Amenity { Id = 6, Name = "Cofee pot" },
                new Amenity { Id = 7, Name = "Computer" },
                new Amenity { Id = 8, Name = "Cot" },
                new Amenity { Id = 11, Name = "Fan" },
                new Amenity { Id = 12, Name = "Kitchen Appliances" },
                new Amenity { Id = 13, Name = "Swimming bool" },
                new Amenity { Id = 14, Name = "Wifi" },
                new Amenity { Id = 15, Name = "Landline" },
                new Amenity { Id = 16, Name = "Parking" },
                new Amenity { Id = 17, Name = "Pets allowed" },
                new Amenity { Id = 18, Name = "Garden" },
                new Amenity { Id = 19, Name = "Gym" },
                new Amenity { Id = 20, Name = "BeachAcess" },
                new Amenity { Id = 21, Name = "Security" },
                new Amenity { Id = 22, Name = "Elevator" },
            });
        }
    }
}
