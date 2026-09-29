using Microsoft.AspNetCore.Mvc;
using UserDetails.Application.Interfaces;

namespace InverstorPortal.Api.Controllers.UserDetails_Module
{
    [ApiController]
    [Route("UserDetails")]
    public class UserDetailsController : ControllerBase
    {
        private readonly IUserDetails _userDetails;
        public UserDetailsController(IUserDetails userDetails) {
            _userDetails = userDetails;

        }

        [HttpGet("GetUserDetails")]
        public async Task<IActionResult> GetUserDetails() {

            var result = await _userDetails.GetUserDetails();

            return Ok(result);
        }
    }
}
