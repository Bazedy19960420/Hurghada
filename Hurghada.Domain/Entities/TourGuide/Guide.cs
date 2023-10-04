namespace Hurghada.Domain.Entities.TourGuide
{
    public class Guide
    {
        public Guide()
        {
            GuideLanguages = new HashSet<GuideLanguage>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string MotherLanguage { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ProfilePhoto { get; set; } = string.Empty;
        public string IDPhoto { get; set; } = string.Empty;
        public bool IsCertified { get; set; }
        public virtual ICollection<GuideLanguage> GuideLanguages { get; set; }


    }
}
