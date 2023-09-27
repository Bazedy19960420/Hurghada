using Hurghada.Domain.Entities.Property;
using Hurghada.Infrastructure.Abstracts.PropertyAbstract;
using Hurghada.Infrastructure.Context;

namespace Hurghada.Infrastructure.Repositories.PropertyRepository
{
    public class PropertyRepository : IPropertyRepository
    {
        #region Fields
        private readonly AppDbContext _context;
        #endregion
        #region Constructors
        public PropertyRepository(AppDbContext context)
        {
            _context = context;
        }
        #endregion
        #region Methods
        public Task<List<Property>> GetPropertiesAsync()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
