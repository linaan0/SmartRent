namespace Domain.Entities;

public class ListingImage
{
    public Guid Id { get; set; }

    public string ImageUrl { get; set; } = string.Empty;

    public bool IsPrimary { get; set; }

    public int DisplayOrder { get; set; }

    public Guid ListingId { get; set; }
    public Listing Listing { get; set; } = null!;
}