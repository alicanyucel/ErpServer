using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erpm.Application.Features.Auth.Register
{
    public sealed record RegisterCommandResponse(
        string Token,
        string RefreshToken,
        DateTime RefreshTokenExpires);
}
