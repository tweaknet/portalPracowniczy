using System.Threading.Tasks;
using portalPracowniczy.ApplicationServices.API.Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portalPracowniczy.Authentication;
using System;

namespace portalPracowniczy.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ApiControllerBase
    {
        public UserController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddUser([FromBody] AddUserRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllUsers([FromQuery] GetUsersRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAll([FromQuery] GetUserLoginRequest request)
        {
            return this.HandleRequest<GetUserLoginRequest, GetUserLoginResponse>(request);
        }

        //[AllowAnonymous]
        //[HttpPost]
        //[Route("authenticate")]
        //public Task<IActionResult> Post([FromBody] ValidateUserRequest request)
        //{
        //    return this.HandleRequest<ValidateUserRequest, ValidateUserResponse>(request);
        //}

        [HttpGet]
        [Route("{userId}")]
        //public User GetUserById(int userId) => this.userRepository.GetById(userId);
        public async Task<IActionResult> GetUserById([FromRoute] int userId)
        {
            var request = new GetUserByIdRequest()
            {
                UserId = userId
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpDelete]
        [Route("{userId}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int userId)
        {

            var request = new DeleteUserRequest()
            {
                UserId = userId
            };
            var response = await this.mediator.Send(request);
            return this.Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> PutUser([FromBody] PutUserRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }


    }
}
