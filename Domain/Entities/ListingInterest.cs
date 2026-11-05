namespace Domain.Entities;

using Domain.Enums;

public class ListingInterest
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public Guid ListingId { get; set; }
    public Listing Listing { get; set; } = null!;

    public InterestStatus Status { get; set; } = InterestStatus.Pending;

    public string? Message { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}