
using Application.Abstractions;
using Domain.Entities;

namespace Infrastructure.Persistence;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _ctx;
    public UnitOfWork(AppDbContext ctx)
    {
        _ctx = ctx;
        Users = new GenericRepository<User>(_ctx);
        Roles = new GenericRepository<Role>(_ctx);
        Projects = new GenericRepository<Project>(_ctx);
        Tasks = new GenericRepository<TaskItem>(_ctx);
        Comments = new GenericRepository<Comment>(_ctx);
        Attachments = new GenericRepository<Attachment>(_ctx);
        RefreshTokens = new GenericRepository<RefreshToken>(_ctx);
    }

    public IGenericRepository<User> Users { get; }
    public IGenericRepository<Role> Roles { get; }
    public IGenericRepository<Project> Projects { get; }
    public IGenericRepository<TaskItem> Tasks { get; }
    public IGenericRepository<Comment> Comments { get; }
    public IGenericRepository<Attachment> Attachments { get; }
    public IGenericRepository<RefreshToken> RefreshTokens { get; }

    public Task<int> SaveChangesAsync(CancellationToken ct = default) => _ctx.SaveChangesAsync(ct);

    public async ValueTask DisposeAsync() => await _ctx.DisposeAsync();
}
