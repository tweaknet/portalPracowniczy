using MediatR;
using Microsoft.AspNetCore.Mvc;
using portalPracowniczy.ApplicationServices.API.Domain;
using System.Threading.Tasks;

namespace portalPracowniczy.Controllers
{
    [ApiController]
        [Route("[controller]")]   
    public class BranchController : ControllerBase
    {
        private readonly IMediator mediator;

        public BranchController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllBranches([FromQuery] GetBranchesRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddBranch([FromBody] AddBranchRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("{branchId}")]
        public async Task<IActionResult> GetBranchById([FromRoute] int branchId)
        {
            var request = new GetBranchByIdRequest()
            {
                Id = branchId
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
        [HttpDelete]
        [Route("{branchId}")]
        public async Task<IActionResult> DeleteBranchById([FromRoute] int branchId)
        {

            var request = new DeleteBranchByIdRequest()
            {
                Id = branchId
            };
            var response = await this.mediator.Send(request);
            return this.Ok();
        }
        [HttpPut]
        [Route("")]
        public async Task<IActionResult> PutBranch([FromBody] PutBranchRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
