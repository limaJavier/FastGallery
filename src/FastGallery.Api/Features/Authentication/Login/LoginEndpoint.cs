using FastEndpoints;
using FastGallery.Application.Authentication.Common;
using FastGallery.Contracts.Authentication;

namespace FastGallery.Api.Features.Authentication.Register;

public class LoginEndpoint : Endpoint<LoginRequest, AuthenticationResult>
{
    public override void Configure()
    {
        Post("/auth/login");
        AllowAnonymous();
    }

    public override async Task HandleAsync(LoginRequest request, CancellationToken cancellationToken)
    {
        var result = new AuthenticationResult(
            request.Email,
            "someToken"
        );
        await SendAsync(result, statusCode: 200);
    }
}