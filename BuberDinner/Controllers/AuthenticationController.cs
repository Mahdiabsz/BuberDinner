using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("Register")]
        public IActionResult Register(RegisterRequest request)
        {
            return Ok(request);
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginRequest request)
        {
            return Ok(request);
        }
    }
}
