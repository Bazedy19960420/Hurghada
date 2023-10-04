namespace Hurghada.Core.Features.TourGuide.Queries.Responses
{
    public class GetGuideByIdResponse
    {

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
        public List<GuideLanguageResponse> GuideLanguages { get; set; } = new List<GuideLanguageResponse>();
    }
    public class GuideLanguageResponse
    {
        public string LanguageName { get; set; } = string.Empty;
        public int LanguageLevel { get; set; }
    }
}
