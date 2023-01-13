using DoublePartnersAPI.DTO;
using DoublePartnersAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DoublePartnersAPI.Controllers.Security
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly ISecurityRepository securityRepository;

        public SecurityController(ISecurityRepository securityRepository)
        {
            this.securityRepository = securityRepository;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Post([FromBody] AuthUserDTO authUser)
        {
            bool isLoggedin = await securityRepository.Login(authUser);

            return isLoggedin ? Ok() : Unauthorized();
        }
    }
}
