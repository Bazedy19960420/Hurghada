using AutoMapper;
using Hurghada.Core.Bases;
using Hurghada.Core.Features.TourGuide.Queries.Models;
using Hurghada.Core.Features.TourGuide.Queries.Responses;
using Hurghada.Service.Abstracts;
using MediatR;

namespace Hurghada.Core.Features.TourGuide.Queries.Handlers
{
    public class GuideQueryHandler : ResponseHandler
        , IRequestHandler<GetGuideByIdQuery, Response<GetGuideByIdResponse>>
        , IRequestHandler<GetGuideListQuery, Response<List<GetGuideByIdResponse>>>
    {
        #region Fields
        private readonly IGuideService _guideService;
        private readonly IMapper _mapper;
        #endregion
        #region Constructors
        public GuideQueryHandler(IGuideService guideService, IMapper mapper)
        {
            _guideService = guideService;
            _mapper = mapper;
        }

        public async Task<Response<GetGuideByIdResponse>> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _guideService.GetGuideAsync(request.Id);
            if (result == null)
                return NotFound<GetGuideByIdResponse>("Guide Does Not Exist");
            var resultMapper = _mapper.Map<GetGuideByIdResponse>(result);
            return Success(resultMapper);
        }

        public async Task<Response<List<GetGuideByIdResponse>>> Handle(GetGuideListQuery request, CancellationToken cancellationToken)
        {
            var result = await _guideService.GetGuidesAsync();
            var resultMapper = _mapper.Map<List<GetGuideByIdResponse>>(result);
            return Success(resultMapper);
        }
        #endregion
        #region Methods


        #endregion
    }
}
