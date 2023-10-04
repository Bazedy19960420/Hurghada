using Hurghada.Domain.Entities.TourGuide;

namespace Hurghada.Service.Abstracts
{
    public interface IGuideService
    {
        Task<List<Guide>> GetGuidesAsync();
        Task<Guide> GetGuideAsync(int id);
        Task<string> AddGuideAsync(Guide guide);
        Task<string> EditGuideAsync(Guide guide);
        Task<string> DeleteGuideAsync(Guide guide);
    }
}
