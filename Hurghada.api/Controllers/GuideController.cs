using Hurghada.api.Base;
using Hurghada.Core.Features.TourGuide.Commands.Models;
using Hurghada.Core.Features.TourGuide.Queries.Models;
using Hurghada.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace Hurghada.api.Controllers
{
    [ApiController]
    public class GuideController : AppControllerBase
    {
        [HttpGet]
        [Route(Router.GuideRouting.GetGuide)]
        public async Task<IActionResult> GetGuideById(int id)
        {
            var result = await Mediator.Send(new GetGuideByIdQuery(id));
            return NewResult(result);
        }
        [HttpGet]
        [Route(Router.GuideRouting.GetGuides)]
        public async Task<IActionResult> GetGuides()
        {
            var result = await Mediator.Send(new GetGuideListQuery());
            return NewResult(result);
        }
        [HttpPost]
        [Route(Router.GuideRouting.AddGuide)]
        public async Task<IActionResult> AddGuide([FromBody] AddGuideCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }
        [HttpDelete]
        [Route(Router.GuideRouting.DeleteGuide)]
        public async Task<IActionResult> DeleteGuide(int id)
        {
            var result = await Mediator.Send(new DeleteGuideCommand(id));
            return NewResult(result);
        }
        [HttpPut]
        [Route(Router.GuideRouting.EditGuide)]
        public async Task<IActionResult> EditGuide([FromBody] EditGuideCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }
    }
}
