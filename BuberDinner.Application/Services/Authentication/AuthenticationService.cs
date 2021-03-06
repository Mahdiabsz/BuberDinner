using BuberDinner.Application.Common.Interfaces.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private IJwtTokenGenerator _jwtTokenGenerator;
        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Login(string email, string password)
        {
            var userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId, "firstName", "lastName");

            return new AuthenticationResult(
                userId,
                "firstname",
                "lastname",
                email,
                token);
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            var userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

            return new AuthenticationResult(
                userId,
                firstName,
                lastName,
                email,
                token);
        }
    }
}
