namespace FastGallery.Application.Authentication.Common;

public record AuthenticationResult(
    string Email,
    string Token
);