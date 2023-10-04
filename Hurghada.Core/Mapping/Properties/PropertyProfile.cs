using AutoMapper;

namespace Hurghada.Core.Mapping.Properties
{
    public partial class PropertyProfile : Profile
    {
        public PropertyProfile()
        {
            GetPropertyListMapping();
            GetPropertyMapping();
            AddPropertyCommandMapping();
            EditPropertyCommandMapping();

        }
    }
}
