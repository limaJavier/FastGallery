namespace FastGallery.Api.Contracts.Pictures;

public record StorePictureRequest(
    string Name,
    FormFile File
);