namespace Domain.Entities;

using Domain.Enums;

public class Listing
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;

    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public double Area { get; set; }

    public int NumberOfRooms { get; set; }
    public int NumberOfBathrooms { get; set; }

    public PropertyType PropertyType { get; set; }

    public bool IsFurnished { get; set; }
    public bool AllowsPets { get; set; }
    public bool AllowsSmoking { get; set; }

    public ListingStatus Status { get; set; } = ListingStatus.Active;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    // Owner relationship

    public Guid OwnerId { get; set; }
    public User Owner { get; set; } = null!;

    // Navigation properties

    public ICollection<ListingImage> Images { get; set; }
        = new List<ListingImage>();

    public ICollection<ListingInterest> Interests { get; set; }
        = new List<ListingInterest>();

    public ICollection<Review> Reviews { get; set; }
        = new List<Review>();

    public ICollection<Payment> Payments { get; set; }
        = new List<Payment>();
}