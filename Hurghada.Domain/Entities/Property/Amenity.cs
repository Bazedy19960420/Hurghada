namespace Hurghada.Domain.Entities.Property
{
    public class Amenity
    {
        public Amenity()
        {
            PropertyAmenities = new HashSet<PropertyAmenity>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<PropertyAmenity> PropertyAmenities { get; set; }
    }
}
