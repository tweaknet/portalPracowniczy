using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MediatR;
using System.Threading.Tasks;

namespace portalPracowniczy.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller)")]
    public class UsersController : ApiControllerBase
    {
        public UsersController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAll([FromQuery] GetUsersLoginRequest request)
        {
            return this.HandlerRequest<GetUsersLoginRequest, GetUsersLoginResponse>(request);
        }
    }
}
