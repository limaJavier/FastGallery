namespace FastGallery.Api.Contracts.Pictures;

public record PictureResponse(
    Guid Id,
    string UserEmail,
    string Name,
    string Url
);