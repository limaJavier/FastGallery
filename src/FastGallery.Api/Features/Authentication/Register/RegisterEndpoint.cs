using FastEndpoints;
using FastGallery.Application.Authentication.Common;
using FastGallery.Contracts.Authentication;

namespace FastGallery.Api.Features.Authentication.Register;

public class RegisterEndpoint : Endpoint<RegisterRequest, AuthenticationResult>
{
    public override void Configure()
    {
        Post("/auth/register");
        AllowAnonymous();
    }

    public override async Task HandleAsync(RegisterRequest request, CancellationToken cancellationToken)
    {
        var result = new AuthenticationResult(
            request.Email,
            "someToken"
        );
        await SendAsync(result, statusCode: 200);
    }
}