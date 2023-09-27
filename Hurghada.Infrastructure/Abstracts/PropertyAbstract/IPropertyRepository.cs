using Hurghada.Domain.Entities.Property;

namespace Hurghada.Infrastructure.Abstracts.PropertyAbstract
{
    public interface IPropertyRepository
    {
        public Task<List<Property>> GetPropertiesAsync();
    }
}
