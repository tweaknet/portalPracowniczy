using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MediatR;
using System.Threading.Tasks;
using portalPracowniczy.ApplicationServices.API.Domain;

namespace portalPracowniczy.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ApiControllerBase
    {
        public UsersController(IMediator mediator) : base(mediator)
        {
        }
        
        [AllowAnonymous]
        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllLogins([FromQuery] GetUserLoginRequest request)
        {
            return this.HandleRequest<GetUserLoginRequest, GetUserLoginResponse>(request);
        }
        //[AllowAnonymous]
        [HttpGet]
        [Route("authenticate")]
        public Task<IActionResult> GetAll([FromQuery] ValidateUserRequest request)
        {
            return this.HandleRequest<ValidateUserRequest, ValidateUserResponse>(request);
        }
    }
}
