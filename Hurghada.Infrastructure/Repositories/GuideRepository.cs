using Hurghada.Domain.Entities.TourGuide;
using Hurghada.Infrastructure.Abstracts;
using Hurghada.Infrastructure.Context;
using Hurghada.Infrastructure.InfrastructureBase;
using Microsoft.EntityFrameworkCore;

namespace Hurghada.Infrastructure.Repositories
{
    public class GuideRepository : GenericRepository<Guide>, IGuideRepository
    {
        #region Fields
        private readonly DbSet<Guide> _context;
        #endregion
        #region Constructors
        public GuideRepository(AppDbContext context) : base(context)
        {
            _context = context.Set<Guide>();
        }
        #endregion
    }
}
