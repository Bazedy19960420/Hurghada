namespace Hurghada.Domain.Entities.Property
{
    public class PropertyAmenity
    {
        public int PropertyId { get; set; }
        public int AmenityId { get; set; }
        public virtual Property Property { get; set; } = default!;
        public virtual Amenity Amenity { get; set; } = default!;
    }
}
