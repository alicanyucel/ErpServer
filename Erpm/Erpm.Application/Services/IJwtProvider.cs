using Erpm.Application.Features.Auth.Login;
using Erpm.Domain.Entities;

namespace Erpm.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
