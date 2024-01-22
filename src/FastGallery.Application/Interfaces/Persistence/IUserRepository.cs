using FastGallery.Domain.Entities;

namespace FastGallery.Application.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}