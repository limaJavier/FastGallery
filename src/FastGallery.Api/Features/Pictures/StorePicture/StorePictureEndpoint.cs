// using FastEndpoints;
// using FastGallery.Api.Contracts.Pictures;

// namespace FastGallery.Api.Features.Pictures;

// public class StorePictureEndpoint : Endpoint<StorePictureRequest, PictureResponse>
// {
//     private readonly IPictureStorage _pictureStorage;
//     private const string SUB_KEY = "ShortTypeName";
//     public override void Configure()
//     {
//         Post("/picture");
//         AllowFileUploads();
//     }

//     public override async Task HandleAsync(StorePictureRequest request, CancellationToken ct)
//     {
//         var userId = User.Claims.FirstOrDefault(
//                 claim => claim.Properties.Keys.Any(
//                     property => property.Contains(SUB_KEY)))!.Value ?? throw new Exception("Token does not cotain \"sub\" claim");

//         var pictureId = Guid.NewGuid();
//     }
// }