using Hurghada.Domain.Entities.Property;

namespace Hurghada.Service.Abstracts
{
    public interface IPropertyService
    {
        Task<List<Property>> GetPropertiesAsync();
        Task<Property> GetPropertyAsync(int id);
        Task<string> AddPropertyAsync(Property property);
        Task<string> EditPropertyAsync(Property property);
        Task<string> DeletePropertyAsync(Property property);
        Task<bool> IsTitleExist(string title);
        Task<bool> IsTitleExistExludeSelf(string title, int id);

    }
}
