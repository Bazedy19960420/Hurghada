using System.ComponentModel.DataAnnotations.Schema;

namespace Hurghada.Domain.Entities.Property
{
    public class PropertyType
    {
        public PropertyType()
        {
            Properties = new HashSet<Property>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [InverseProperty(nameof(Property.PropertyType))]
        public virtual ICollection<Property> Properties { get; set; }
    }
}
