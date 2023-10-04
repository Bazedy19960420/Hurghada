using AutoMapper;

namespace Hurghada.Core.Mapping.TourGuide
{
    public partial class TourGuideProfile : Profile
    {
        public TourGuideProfile()
        {
            GetGuideByIdMapping();
            AddGuideCommandMapping();
            EditGuideCommandMapping();
        }
    }
}
