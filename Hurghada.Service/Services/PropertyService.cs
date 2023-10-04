using Hurghada.Domain.Entities.Property;
using Hurghada.Infrastructure.Abstracts.PropertyAbstract;
using Hurghada.Service.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace Hurghada.Service.Services
{
    public class PropertyService : IPropertyService
    {
        #region Feilds
        private readonly IPropertyRepository _propertyRepository;
        #endregion

        #region Constructors
        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        #endregion
        #region Methods
        public Task<List<Property>> GetPropertiesAsync()
        {
            return _propertyRepository.GetPropertiesAsync();
        }
        public async Task<Property> GetPropertyAsync(int id)
        {
            var property = _propertyRepository.GetTableNoTracking().Where(x => x.Id == id).Include(x => x.PropertyType).Include(x => x.PropertyAmenities).ThenInclude(x => x.Amenity).FirstOrDefault();
            return property;
        }
        public async Task<string> AddPropertyAsync(Property property)
        {

            await _propertyRepository.AddAsync(property);
            return "Success";
        }

        public async Task<bool> IsTitleExist(string title)
        {
            var result = _propertyRepository.GetTableNoTracking().Where(x => x.Title == title).FirstOrDefault();
            if (result == null)
                return false;
            return true;
        }

        public async Task<bool> IsTitleExistExludeSelf(string title, int id)
        {
            var result = _propertyRepository.GetTableNoTracking().Where(x => x.Title == title && x.Id != id).FirstOrDefault();
            if (result == null)
                return false;
            return true;

        }

        public async Task<string> EditPropertyAsync(Property property)
        {
            await _propertyRepository.UpdateAsync(property);
            return "Success";
        }

        public async Task<string> DeletePropertyAsync(Property property)
        {
            await _propertyRepository.DeleteAsync(property);
            return "Success";

        }

        #endregion


    }
}
