using AutoMapper;
using Hurghada.Core.Bases;
using Hurghada.Core.Features.Properties.Queries.Models;
using Hurghada.Core.Features.Properties.Queries.Responses;
using Hurghada.Service.Abstracts;
using MediatR;

namespace Hurghada.Core.Features.Properties.Queries.Handlers
{
    public class PropertyHandler : ResponseHandler
        , IRequestHandler<GetPropertyListQuery, Response<List<GetPropertyListResponse>>>
        , IRequestHandler<GetPropertyQuery, Response<GetPropertyResponse>>
    {
        #region Feilds
        private readonly IPropertyService _propertyService;
        private readonly IMapper _mapper;
        #endregion
        #region Constructors
        public PropertyHandler(IPropertyService propertyService, IMapper mapper)
        {
            _propertyService = propertyService;
            _mapper = mapper;
        }




        #endregion
        #region Methods
        public async Task<Response<List<GetPropertyListResponse>>> Handle(GetPropertyListQuery request, CancellationToken cancellationToken)
        {
            var result = await _propertyService.GetPropertiesAsync();
            var resultMapper = _mapper.Map<List<GetPropertyListResponse>>(result);
            return Success(resultMapper);
        }

        public async Task<Response<GetPropertyResponse>> Handle(GetPropertyQuery request, CancellationToken cancellationToken)
        {
            var result = await _propertyService.GetPropertyAsync(request.Id);
            if (result == null)
                return NotFound<GetPropertyResponse>("Property Does Not Exist");
            var resultMapper = _mapper.Map<GetPropertyResponse>(result);
            return Success(resultMapper);
        }

        #endregion
    }
}
