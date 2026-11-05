namespace Domain.Entities;

public class SavedSearch
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public string Name { get; set; } = string.Empty;

    public decimal? MinimumPrice { get; set; }
    public decimal? MaximumPrice { get; set; }

    public string? Location { get; set; }

    public int? MinimumRooms { get; set; }
    public int? MaximumRooms { get; set; }

    public double? MinimumArea { get; set; }
    public double? MaximumArea { get; set; }

    public bool? IsFurnished { get; set; }
    public bool? AllowsPets { get; set; }
    public bool? AllowsSmoking { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}