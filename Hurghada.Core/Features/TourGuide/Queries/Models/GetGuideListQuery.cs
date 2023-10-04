using Hurghada.Core.Bases;
using Hurghada.Core.Features.TourGuide.Queries.Responses;
using MediatR;

namespace Hurghada.Core.Features.TourGuide.Queries.Models
{
    public class GetGuideListQuery : IRequest<Response<List<GetGuideByIdResponse>>>
    {

    }
}
