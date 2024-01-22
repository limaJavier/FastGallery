using FastGallery.Application.Authentication.Common;
using MediatR;

namespace FastGallery.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password
) : IRequest<AuthenticationResult>;