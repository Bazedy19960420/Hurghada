using Hurghada.Domain.Entities.Property;
using Hurghada.Infrastructure.InfrastructureBase;

namespace Hurghada.Infrastructure.Abstracts.PropertyAbstract
{
    public interface IPropertyRepository : IGenericRepository<Property>
    {
        public Task<List<Property>> GetPropertiesAsync();
    }
}
