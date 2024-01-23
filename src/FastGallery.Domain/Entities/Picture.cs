namespace FastGallery.Domain.Entities;

public class Picture
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Name { get; set; } = null!;
    public string Url { get; set; } = null!;
}