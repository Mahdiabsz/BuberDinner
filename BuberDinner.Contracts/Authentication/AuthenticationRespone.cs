using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Contracts.Authentication
{
    public record AuthenticationRespone(
        Guid Id,
        string Firstname,
        string Lastname,
        string Email,
        string Token);
}
