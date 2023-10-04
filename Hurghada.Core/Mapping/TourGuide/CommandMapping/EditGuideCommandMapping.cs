using Hurghada.Core.Features.TourGuide.Commands.Models;
using Hurghada.Domain.Entities.TourGuide;

namespace Hurghada.Core.Mapping.TourGuide
{
    public partial class TourGuideProfile
    {
        public void EditGuideCommandMapping()
        {
            CreateMap<EditGuideCommand, Guide>()
                 .ForMember(dest => dest.GuideLanguages, opt => opt.MapFrom(src => src.GuideLanguages.Select(gl => new GuideLanguage { LanguageId = gl.Id, GuideLanguageLevel = gl.LanguageLevel })));
        }
    }
}
