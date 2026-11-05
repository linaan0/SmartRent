namespace Domain.Entities;

public class Review
{
    public Guid Id { get; set; }

    public Guid ReviewerId { get; set; }
    public User Reviewer { get; set; } = null!;

    public Guid ReviewedUserId { get; set; }
    public User ReviewedUser { get; set; } = null!;

    public Guid? ListingId { get; set; }
    public Listing? Listing { get; set; }

    public int Rating { get; set; }

    public string? Comment { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}