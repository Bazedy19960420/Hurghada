using Hurghada.Core.Features.Properties.Queries.Responses;
using Hurghada.Domain.Entities.Property;

namespace Hurghada.Core.Mapping.Properties
{
    public partial class PropertyProfile
    {
        public void GetPropertyMapping()
        {
            CreateMap<PropertyAmenity, PropertyAmenitiesResponse>()
                .ForMember(PropertyAmenitiesResponse => PropertyAmenitiesResponse.AmenityName, opt => opt.MapFrom(Amenity => Amenity.Amenity.Name));
            CreateMap<Property, GetPropertyResponse>()
                .ForMember(p => p.PropertyTypeName, opt => opt.MapFrom(p => p.PropertyType.Name));

        }
    }
}

