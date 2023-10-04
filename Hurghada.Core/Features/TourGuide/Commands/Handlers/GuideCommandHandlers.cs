using AutoMapper;
using Hurghada.Core.Bases;
using Hurghada.Core.Features.TourGuide.Commands.Models;
using Hurghada.Domain.Entities.TourGuide;
using Hurghada.Service.Abstracts;
using MediatR;

namespace Hurghada.Core.Features.TourGuide.Commands.Handlers
{
    public class GuideCommandHandlers : ResponseHandler,
        IRequestHandler<AddGuideCommand, Response<string>>,
        IRequestHandler<DeleteGuideCommand, Response<string>>,
        IRequestHandler<EditGuideCommand, Response<string>>
    {
        #region Fields
        private readonly IGuideService _guideService;
        private readonly IMapper _mapper;
        #endregion
        #region Constructors
        public GuideCommandHandlers(IGuideService guideService, IMapper mapper)
        {
            _guideService = guideService;
            _mapper = mapper;
        }
        #endregion
        #region Methods
        public async Task<Response<string>> Handle(AddGuideCommand request, CancellationToken cancellationToken)
        {
            var guide = _mapper.Map<Guide>(request);
            var result = await _guideService.AddGuideAsync(guide);
            if (result == "Success")
                return Success<string>("Added Successfully");
            else
                return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(DeleteGuideCommand request, CancellationToken cancellationToken)
        {
            var guide = await _guideService.GetGuideAsync(request.Id);
            if (guide == null)
                return BadRequest<string>();
            var result = await _guideService.DeleteGuideAsync(guide);
            if (result == "Success")
                return Deleted<string>();
            else
                return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(EditGuideCommand request, CancellationToken cancellationToken)
        {
            var guide = await _guideService.GetGuideAsync(request.Id);
            if (guide == null)
                return NotFound<string>("Guide Not Found");
            var guideMapper = _mapper.Map<Guide>(request);
            var result = await _guideService.EditGuideAsync(guideMapper);
            if (result == "Success")
                return Success<string>("Edited Successfully");
            else
                return BadRequest<string>();
        }
        #endregion
    }
}
