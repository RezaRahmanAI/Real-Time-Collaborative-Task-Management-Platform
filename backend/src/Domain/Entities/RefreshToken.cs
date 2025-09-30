namespace Domain.Entities;

public class RefreshToken : BaseEntity
{
    public string Token { get; set; } = default!;
    public DateTime ExpiresAtUtc { get; set; }
    public bool Revoked { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = default!;
}
