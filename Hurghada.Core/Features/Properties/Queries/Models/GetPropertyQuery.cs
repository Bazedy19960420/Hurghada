using Hurghada.Core.Bases;
using Hurghada.Core.Features.Properties.Queries.Responses;
using MediatR;

namespace Hurghada.Core.Features.Properties.Queries.Models
{
    public class GetPropertyQuery : IRequest<Response<GetPropertyResponse>>
    {
        public int Id { get; set; }
        public GetPropertyQuery(int id)
        {
            Id = id;
        }
    }
}
