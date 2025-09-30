namespace Domain.Entities;

public class Attachment : BaseEntity
{
    public string FileName { get; set; } = default!;
    public string ContentType { get; set; } = default!;
    public long SizeBytes { get; set; }
    public string StoragePath { get; set; } = default!; // (We’ll swap to cloud later)

    public Guid TaskItemId { get; set; }
    public TaskItem TaskItem { get; set; } = default!;
}
