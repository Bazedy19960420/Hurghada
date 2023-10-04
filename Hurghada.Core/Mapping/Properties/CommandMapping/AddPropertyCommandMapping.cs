using Hurghada.Core.Features.Properties.Commands.Models;
using Hurghada.Domain.Entities.Property;

namespace Hurghada.Core.Mapping.Properties
{
    public partial class PropertyProfile
    {
        public void AddPropertyCommandMapping()
        {
            CreateMap<AddPropertyCommand, Property>()
                .ForMember(p => p.PropertyAmenities, opt => opt.MapFrom(p => p.PropertyAmenities.Select(pa => new PropertyAmenity { AmenityId = pa })));
        }
    }
}
