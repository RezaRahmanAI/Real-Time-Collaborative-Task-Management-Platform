using Domain.Entities;

namespace Application.Abstractions;

public interface IUnitOfWork : IAsyncDisposable
{
    IGenericRepository<User> Users { get; }
    IGenericRepository<Role> Roles { get; }
    IGenericRepository<Project> Projects { get; }
    IGenericRepository<TaskItem> Tasks { get; }
    IGenericRepository<Comment> Comments { get; }
    IGenericRepository<Attachment> Attachments { get; }
    IGenericRepository<RefreshToken> RefreshTokens { get; }

    Task<int> SaveChangesAsync(CancellationToken ct = default);
}
