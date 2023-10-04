using System.ComponentModel.DataAnnotations;
namespace Hurghada.Domain.Entities.TourGuide
{
    public class GuideLanguage
    {
        public int GuideId { get; set; }
        public Guide Guide { get; set; } = default!;
        public int LanguageId { get; set; }
        public Language Language { get; set; } = default!;
        [Range(1, 5)]
        public int GuideLanguageLevel { get; set; }
    }
}
