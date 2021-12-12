using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MediatR;
using System.Threading.Tasks;
using portalPracowniczy.ApplicationServices.API.Domain;

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
        public Task<IActionResult> GetAll([FromQuery] GetUserLoginRequest request)
        {
            return this.HandlerRequest<GetUserLoginRequest, GetUserLoginResponse>(request);
        }
    }
}
