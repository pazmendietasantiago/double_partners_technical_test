using DoublePartnersAPI.DTO;
using DoublePartnersAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DoublePartnersAPI.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> Get()
        {
            IEnumerable<UserDTO> users = await userRepository.GetUsers();

            return Ok(users);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Post([FromBody] UserDTO user)
        {
            bool result = await userRepository.SaveUser(user);

            return result ? Ok() : Conflict();
        }
    }
}
