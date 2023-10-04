using Hurghada.Domain.Entities.TourGuide;
using Hurghada.Infrastructure.Abstracts;
using Hurghada.Service.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace Hurghada.Service.Services
{
    public class GuideService : IGuideService
    {
        #region Fields
        private readonly IGuideRepository _guideRepository;
        #endregion
        #region Constructors
        public GuideService(IGuideRepository guideRepository)
        {
            _guideRepository = guideRepository;
        }
        #endregion
        #region Methods

        public async Task<string> AddGuideAsync(Guide guide)
        {
            await _guideRepository.AddAsync(guide);
            return "Success";
        }

        public async Task<string> DeleteGuideAsync(Guide guide)
        {
            var transaction = _guideRepository.BeginTransaction();
            try
            {
                _guideRepository.DeleteAsync(guide);
                transaction.Commit();
                return ("Success");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return (ex.Message);
            }
        }

        public async Task<string> EditGuideAsync(Guide guide)
        {
            await _guideRepository.UpdateAsync(guide);
            return "Success";
        }

        public async Task<List<Guide>> GetGuidesAsync()
        {
            var guides = _guideRepository.GetTableNoTracking().Include(x => x.GuideLanguages).ThenInclude(x => x.Language).ToList();
            return guides;
        }

        public async Task<Guide> GetGuideAsync(int id)
        {
            var guide = _guideRepository.GetTableNoTracking().Where(x => x.Id == id).Include(x => x.GuideLanguages).ThenInclude(x => x.Language).FirstOrDefault();
            return guide;
        }
        #endregion
    }
}
