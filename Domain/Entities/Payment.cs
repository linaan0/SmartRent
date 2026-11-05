namespace Domain.Entities;

using Domain.Enums;

public class Payment
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public Guid? ListingId { get; set; }
    public Listing? Listing { get; set; }

    public decimal Amount { get; set; }

    public string Currency { get; set; } = "EUR";

    public PaymentType Type { get; set; }

    public PaymentStatus Status { get; set; } = PaymentStatus.Pending;

    public string? ProviderTransactionId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? CompletedAt { get; set; }
}