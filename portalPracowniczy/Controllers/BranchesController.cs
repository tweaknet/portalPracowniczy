using MediatR;
using Microsoft.AspNetCore.Mvc;
using portalPracowniczy.ApplicationServices.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portalPracowniczy.Controllers
{
         [ApiController]
        [Route("[controller]")]   
    public class BranchesController : ControllerBase
    {
        private readonly IMediator mediator;

        public BranchesController(IMediator mediator)
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
    }
}
