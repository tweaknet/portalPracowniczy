using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MediatR;
using System.Threading.Tasks;
using portalPracowniczy.Authentication;
using portalPracowniczy.ApplicationServices.API.Domain;
using Microsoft.Extensions.Logging;

namespace portalPracowniczy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ApiControllerBase
    {
        public UsersController(IMediator mediator, ILogger<UsersController> logger)
            : base(mediator)
        {
            logger.LogInformation("we are in users");
        }
        [Authorize]
        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllUsers([FromQuery] GetUserLoginRequest request)
        {
            return this.HandleRequest<GetUserLoginRequest, GetUserLoginResponse>(request);
        }
        //[Authorize]
        [HttpGet]
        [Route("authenticate")]
        public Task<IActionResult> Get([FromQuery] ValidateUserRequest request)
        {
            System.Console.WriteLine("KK"+request);
            return this.HandleRequest<ValidateUserRequest, ValidateUserResponse>(request);
        }
        [HttpGet]
        [Route("r")]
        public Task<IActionResult> GetName([FromQuery] ValidateUserRequest request)
        {
            return this.HandleRequest<ValidateUserRequest, ValidateUserResponse>(request);
        }
    }
}
