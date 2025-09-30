using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<UserRole> UserRoles => Set<UserRole>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<ProjectMember> ProjectMembers => Set<ProjectMember>();
    public DbSet<TaskItem> Tasks => Set<TaskItem>();
    public DbSet<Comment> Comments => Set<Comment>();
    public DbSet<Attachment> Attachments => Set<Attachment>();
    public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();

    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<UserRole>().HasKey(x => new { x.UserId, x.RoleId });
        b.Entity<ProjectMember>().HasKey(x => new { x.ProjectId, x.UserId });

        b.Entity<User>().HasIndex(u => u.UserName).IsUnique();
        b.Entity<User>().HasIndex(u => u.Email).IsUnique();

        // Relationships
        b.Entity<TaskItem>()
            .HasOne(t => t.Project).WithMany(p => p.Tasks).HasForeignKey(t => t.ProjectId);
        b.Entity<TaskItem>()
            .HasOne(t => t.Assignee).WithMany().HasForeignKey(t => t.AssigneeId).OnDelete(DeleteBehavior.SetNull);

        b.Entity<Comment>()
            .HasOne(c => c.TaskItem).WithMany(t => t.Comments).HasForeignKey(c => c.TaskItemId);
        b.Entity<Comment>()
            .HasOne(c => c.Author).WithMany().HasForeignKey(c => c.AuthorId);

        b.Entity<Attachment>()
            .HasOne(a => a.TaskItem).WithMany(t => t.Attachments).HasForeignKey(a => a.TaskItemId);
    }
}
