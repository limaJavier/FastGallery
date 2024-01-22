using FastGallery.Application.Authentication.Common;
using FastGallery.Application.Interfaces.Authentication;
using FastGallery.Application.Interfaces.Persistence;
using FastGallery.Domain.Entities;
using MediatR;

namespace FastGallery.Application.Authentication.Commands.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AuthenticationResult>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public async Task<AuthenticationResult> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        // TODO: Use a mapper to create user
        // Create user
        var user = new User()
        {
            Id = Guid.NewGuid(),
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
            Password = command.Password
        };

        // Store user into DB
        _userRepository.Add(user);

        // Generate token
        var token = _jwtTokenGenerator.GenerateToken(user);

        // Create result
        var result = new AuthenticationResult(
            user.Email,
            token
        );

        // Use this line to avoid warning, in the future the DB store process will be async
        await Task.CompletedTask;

        return result;
    }
}