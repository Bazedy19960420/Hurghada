using Hurghada.Domain.Entities.Property;
using Hurghada.Infrastructure.Abstracts.PropertyAbstract;
using Hurghada.Infrastructure.Context;
using Hurghada.Infrastructure.InfrastructureBase;
using Microsoft.EntityFrameworkCore;

namespace Hurghada.Infrastructure.Repositories.PropertyRepository
{
    public class PropertyRepository : GenericRepository<Property>, IPropertyRepository
    {
        #region Fields
        private readonly DbSet<Property> _context;
        #endregion
        #region Constructors
        public PropertyRepository(AppDbContext context) : base(context)
        {
            _context = context.Set<Property>();
        }
        #endregion
        #region Methods
        public async Task<List<Property>> GetPropertiesAsync()
        {
            return await _context.Include(p => p.PropertyType)
                .Include(p => p.PropertyAmenities).ThenInclude(p => p.Amenity).ToListAsync();
        }
        #endregion
    }
}
