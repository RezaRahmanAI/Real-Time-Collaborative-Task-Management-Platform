using Domain.Entities;
using System.Security.Claims;

namespace Application.Abstractions;

public interface IJwtTokenService
{
    string CreateAccessToken(User user, IEnumerable<string> roles, IEnumerable<Claim>? extraClaims = null);
}
