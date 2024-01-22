using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using FastGallery.Application.Interfaces.Authentication;
using FastGallery.Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace FastGallery.Infrastructure.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    public string GenerateToken(User user)
    {
        var key = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes("000000000somePassword11111111123456789")),
            SecurityAlgorithms.HmacSha256
        );

        var claims = new Claim[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, user.FirstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, user.LastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var securityToken = new JwtSecurityToken(
            signingCredentials: key,
            issuer: "FastGallery",
            audience: "FastGallery",
            expires: DateTime.UtcNow.AddMinutes(60),
            claims: claims
        );

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }
}