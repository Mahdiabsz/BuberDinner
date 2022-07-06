using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("Register")]
        public IActionResult Register(RegisterRequest request)
        {
            var authResult = _authenticationService.Register(
                request.Firstname,
                request.Lastname,
                request.Email,
                request.Password);

            var response = new AuthenticationRespone(
                Guid.NewGuid(),
                authResult.Firstname,
                authResult.Lastname,
                authResult.Email,
                "token");

            return Ok(response);
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationService.Login(
                request.Email,
                request.Password);

            var response = new AuthenticationRespone(
                Guid.NewGuid(),
                authResult.Firstname,
                authResult.Lastname,
                authResult.Email,
                "token");

            return Ok(response);
        }
    }
}
