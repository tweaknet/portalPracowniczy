using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MediatR;
using System.Threading.Tasks;
using portalPracowniczy.Authentication;
using portalPracowniczy.ApplicationServices.API.Domain;

namespace portalPracowniczy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ApiControllerBase
    {
        public UsersController(IMediator mediator)
            : base(mediator)
        {
        }
        [Authorize]
        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllUsers([FromQuery] GetUserLoginRequest request)
        {
            return this.HandleRequest<GetUserLoginRequest, GetUserLoginResponse>(request);
        }
        [HttpGet]
        [Route("r")]
        public Task<IActionResult> GetName([FromQuery] ValidateUserRequest request)
        {
            return this.HandleRequest<ValidateUserRequest, ValidateUserResponse>(request);
        }
    }
}
