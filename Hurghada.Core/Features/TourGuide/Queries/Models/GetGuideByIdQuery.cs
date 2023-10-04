using Hurghada.Core.Bases;
using Hurghada.Core.Features.TourGuide.Queries.Responses;
using MediatR;

namespace Hurghada.Core.Features.TourGuide.Queries.Models
{
    public class GetGuideByIdQuery : IRequest<Response<GetGuideByIdResponse>>
    {
        public int Id { get; set; }
        public GetGuideByIdQuery(int id)
        {
            Id = id;
        }
    }
}
