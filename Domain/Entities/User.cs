namespace Domain.Entities;

using Domain.Enums;

public class User
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;

    public string? ProfilePictureUrl { get; set; }

    public UserRole Role { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public bool IsActive { get; set; } = true;

    // Navigation properties

    public ICollection<Listing> Listings { get; set; } = new List<Listing>();

    public ICollection<ListingInterest> ListingInterests { get; set; }
        = new List<ListingInterest>();

    public RoommateProfile? RoommateProfile { get; set; }

    public ICollection<ConversationParticipant> Conversations { get; set; }
        = new List<ConversationParticipant>();

    public ICollection<Message> Messages { get; set; }
        = new List<Message>();

    public ICollection<Review> GivenReviews { get; set; }
        = new List<Review>();

    public ICollection<Review> ReceivedReviews { get; set; }
        = new List<Review>();

    public ICollection<Notification> Notifications { get; set; }
        = new List<Notification>();

    public ICollection<SavedSearch> SavedSearches { get; set; }
        = new List<SavedSearch>();
}