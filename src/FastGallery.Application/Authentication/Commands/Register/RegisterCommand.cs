using FastGallery.Application.Authentication.Common;
using MediatR;

namespace FastGallery.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password
) : IRequest<AuthenticationResult>;