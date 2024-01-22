using FastEndpoints;
using FastGallery.Application.Authentication.Common;
using FastGallery.Application.Authentication.Queries.Login;
using FastGallery.Contracts.Authentication;
using MediatR;

namespace FastGallery.Api.Features.Authentication.Register;

public class LoginEndpoint : Endpoint<LoginRequest, AuthenticationResult>
{
    private readonly ISender _mediator;

    public LoginEndpoint(ISender mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        Post("/auth/login");
        AllowAnonymous();
    }

    public override async Task HandleAsync(LoginRequest request, CancellationToken cancellationToken)
    {
        var query = new LoginQuery(
            request.Email,
            request.Password
        );

        var result = await _mediator.Send(query);

        await SendAsync(result, statusCode: 200);
    }
}