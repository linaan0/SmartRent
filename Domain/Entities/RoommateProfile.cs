namespace Domain.Entities;

public class RoommateProfile
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public int Age { get; set; }

    public decimal MinimumBudget { get; set; }
    public decimal MaximumBudget { get; set; }

    public string PreferredLocation { get; set; } = string.Empty;

    public bool IsSmoker { get; set; }
    public bool HasPets { get; set; }

    public string? LifestyleDescription { get; set; }
    public string? Preferences { get; set; }

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}