using Domain.Enums;
using System.Net.Mail;
using System.Xml.Linq;
using TaskStatus = Domain.Enums.TaskStatus;

namespace Domain.Entities;

public class TaskItem : BaseEntity
{
    public string Title { get; set; } = default!;
    public string? Description { get; set; }
    public TaskStatus Status { get; set; } = TaskStatus.ToDo;
    public PriorityLevel Priority { get; set; } = PriorityLevel.Medium;
    public DateTime? DueDateUtc { get; set; }

    public Guid ProjectId { get; set; }
    public Project Project { get; set; } = default!;

    public Guid? AssigneeId { get; set; }
    public User? Assignee { get; set; }

    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
}
