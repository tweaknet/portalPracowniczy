using Microsoft.AspNetCore.Mvc;
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
        private readonly IRepository<User> userRepository;

        public UserController(IRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }
        [HttpGet]
        [Route("")]
        public IEnumerable<User> GetAllUsers() => this.userRepository.GetAll();

        [HttpGet]
        [Route("{userId}")]
        public User GetUserById(int userId) => this.userRepository.GetById(userId);
    }
}
