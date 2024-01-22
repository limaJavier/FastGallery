using FastEndpoints;
using FastGallery.Application.Authentication.Commands.Register;
using FastGallery.Application.Authentication.Common;
using FastGallery.Contracts.Authentication;
using MediatR;

namespace FastGallery.Api.Features.Authentication.Register;

public class RegisterEndpoint : Endpoint<RegisterRequest, AuthenticationResult>
{
    private readonly ISender _mediator;

    public RegisterEndpoint(ISender mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        Post("/auth/register");
        AllowAnonymous();
    }

    public override async Task HandleAsync(RegisterRequest request, CancellationToken cancellationToken)
    {
        // TODO: Use a mapper to create command
        // Create command
        var command = new RegisterCommand(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password
        );

        var result = await _mediator.Send(command);
        
        await SendAsync(result, statusCode: 200);
    }
}