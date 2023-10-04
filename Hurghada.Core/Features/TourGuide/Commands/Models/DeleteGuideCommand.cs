using Hurghada.Core.Bases;
using MediatR;

namespace Hurghada.Core.Features.TourGuide.Commands.Models
{
    public class DeleteGuideCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public DeleteGuideCommand(int id)
        {
            Id = id;
        }
    }
}
