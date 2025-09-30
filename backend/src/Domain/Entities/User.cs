namespace Domain.Entities;

public class User : BaseEntity
{
    public string UserName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PasswordHash { get; set; } = default!;
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    public ICollection<ProjectMember> ProjectMembers { get; set; } = new List<ProjectMember>();
}
