using System.ComponentModel.DataAnnotations;

namespace Hurghada.Domain.Entities.TourGuide
{
    public class Language
    {
        public Language()
        {
            GuideLanguages = new HashSet<GuideLanguage>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Range(1, 5)]
        public virtual ICollection<GuideLanguage> GuideLanguages { get; set; }

    }
}
