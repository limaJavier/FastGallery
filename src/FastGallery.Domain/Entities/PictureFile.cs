namespace FastGallery.Domain.Entities;

public class PictureFile
{
    public Guid Id { get; set; }
    public byte[] Bytes { get; set; } = null!;
}