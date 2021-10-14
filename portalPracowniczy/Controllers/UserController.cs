using MediatR;
using Microsoft.AspNetCore.Mvc;
using portalPracowniczy.ApplicationServices.API.Domain;
using portalPracowniczy.DataAccess;
using portalPracowniczy.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portalPracowniczy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
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

        //[HttpGet]
        //[Route("{userId}")]
        ////public User GetUserById(int userId) => this.userRepository.GetById(userId);
        //public async Task<IActionResult> GetUserById([FromQuery] GetUsersRequest request)
        //{ 
        //    var response = await this.mediator.Send(request);
        //    return this.Ok(response);
        //}
    }
}
