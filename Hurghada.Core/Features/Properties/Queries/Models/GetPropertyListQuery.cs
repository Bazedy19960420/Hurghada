using Hurghada.Core.Bases;
using Hurghada.Core.Features.Properties.Queries.Responses;
using MediatR;

namespace Hurghada.Core.Features.Properties.Queries.Models
{
    public class GetPropertyListQuery : IRequest<Response<List<GetPropertyListResponse>>>
    {
    }
}
