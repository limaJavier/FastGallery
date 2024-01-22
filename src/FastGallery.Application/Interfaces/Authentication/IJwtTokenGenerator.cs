using FastGallery.Domain.Entities;

namespace FastGallery.Application.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}