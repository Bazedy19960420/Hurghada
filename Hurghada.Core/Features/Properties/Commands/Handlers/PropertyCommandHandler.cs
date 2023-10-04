using AutoMapper;
using Hurghada.Core.Bases;
using Hurghada.Core.Features.Properties.Commands.Models;
using Hurghada.Domain.Entities.Property;
using Hurghada.Service.Abstracts;
using MediatR;

namespace Hurghada.Core.Features.Properties.Commands.Handlers
{
    public class PropertyCommandHandler : ResponseHandler
        , IRequestHandler<AddPropertyCommand, Response<string>>
        , IRequestHandler<EditPropertyCommand, Response<string>>
        , IRequestHandler<DeletePropertyCommand, Response<string>>
    {
        #region Fields
        private readonly IPropertyService _propertyService;
        private readonly IMapper _mapper;
        #endregion
        #region Constructors
        public PropertyCommandHandler(IPropertyService propertyService, IMapper mapper)
        {
            _propertyService = propertyService;
            _mapper = mapper;
        }
        #endregion
        #region Methods
        public async Task<Response<string>> Handle(AddPropertyCommand request, CancellationToken cancellationToken)
        {
            var property = _mapper.Map<Property>(request);

            var result = await _propertyService.AddPropertyAsync(property);

            if (result == "Exist")
            {
                return UnprocessableEntity<string>("Title Already Exist");
            }
            if (result == "Success")
                return Created<string>("Added Successfully");

            else
                return BadRequest<string>();

        }

        public async Task<Response<string>> Handle(EditPropertyCommand request, CancellationToken cancellationToken)
        {
            var property = await _propertyService.GetPropertyAsync(request.Id);
            if (property == null)
                return NotFound<string>("Property Not Found");
            var propertyMapper = _mapper.Map<Property>(request);
            var result = await _propertyService.EditPropertyAsync(propertyMapper);
            if (result == "Success")
                return Success<string>("Edited Successfully");
            else
                return BadRequest<string>();


        }

        public async Task<Response<string>> Handle(DeletePropertyCommand request, CancellationToken cancellationToken)
        {
            var property = await _propertyService.GetPropertyAsync(request.Id);
            if (property == null)
                return NotFound<string>("Property Not Found");
            var result = await _propertyService.DeletePropertyAsync(property);
            if (result == "Success")
                return Deleted<string>();
            else
                return BadRequest<string>();
        }
        #endregion
    }
}
