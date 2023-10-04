using Hurghada.Core.Features.TourGuide.Queries.Responses;
using Hurghada.Domain.Entities.TourGuide;

namespace Hurghada.Core.Mapping.TourGuide
{
    public partial class TourGuideProfile
    {
        public void GetGuideByIdMapping()
        {
            CreateMap<GuideLanguage, GuideLanguageResponse>()
                .ForMember(GuideLanguageResponse => GuideLanguageResponse.LanguageName, opt => opt.MapFrom(GuideLanguage => GuideLanguage.Language.Name))
                .ForMember(GuideLanguageResponse => GuideLanguageResponse.LanguageLevel, opt => opt.MapFrom(GuideLanguage => GuideLanguage.GuideLanguageLevel));
            CreateMap<Guide, GetGuideByIdResponse>()
                .ForMember(GetGuideByIdResponse => GetGuideByIdResponse.GuideLanguages, opt => opt.MapFrom(Guide => Guide.GuideLanguages));
        }
    }
}
