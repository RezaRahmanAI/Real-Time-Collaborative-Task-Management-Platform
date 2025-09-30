namespace Domain.Entities;

public class Project : BaseEntity
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    public ICollection<ProjectMember> Members { get; set; } = new List<ProjectMember>();
}

public class ProjectMember
{
    public Guid ProjectId { get; set; }
    public Project Project { get; set; } = default!;
    public Guid UserId { get; set; }
    public User User { get; set; } = default!;
}
