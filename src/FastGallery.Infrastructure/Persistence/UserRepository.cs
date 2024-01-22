using FastGallery.Application.Interfaces.Persistence;
using FastGallery.Domain.Entities;

namespace FastGallery.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private readonly static List<User> _users = new List<User>();

    public void Add(User user) => _users.Add(user);

    public User? GetUserByEmail(string email) => _users.FirstOrDefault(u => u.Email == email);
}