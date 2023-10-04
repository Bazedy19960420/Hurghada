using Hurghada.api.Base;
using Hurghada.Core.Features.Properties.Commands.Models;
using Hurghada.Core.Features.Properties.Queries.Models;
using Hurghada.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace Hurghada.api.Controllers
{
    [ApiController]
    public class PropertyController : AppControllerBase
    {
        #region Fields
        #endregion
        #region Constructors

        #endregion
        #region Methods
        [HttpGet]
        [Route(Router.PropertyRouting.GetProperties)]
        public async Task<IActionResult> Get()
        {
            var result = await Mediator.Send(new GetPropertyListQuery());
            return NewResult(result);
        }
        [HttpGet]
        [Route(Router.PropertyRouting.GetProperty)]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var result = await Mediator.Send(new GetPropertyQuery(id));
            return NewResult(result);
        }
        [HttpPost]
        [Route(Router.PropertyRouting.AddProperty)]
        public async Task<IActionResult> Add([FromForm] AddPropertyCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }
        [HttpPut]
        [Route(Router.PropertyRouting.EditProperty)]
        public async Task<IActionResult> Edit([FromForm] EditPropertyCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpDelete]
        [Route(Router.PropertyRouting.DeleteProperty)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var result = await Mediator.Send(new DeletePropertyCommand(id));
            return NewResult(result);
        }
        #endregion
    }
}
