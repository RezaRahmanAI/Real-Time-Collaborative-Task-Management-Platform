using Application;
using Application.Abstractions;
using Infrastructure.Persistence;
using Infrastructure.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        var conn = config.GetConnectionString("DefaultConnection")
                   ?? "Server=(localdb)\\MSSQLLocalDB;Database=TaskDb;Trusted_Connection=True;TrustServerCertificate=True;";
        services.AddDbContext<AppDbContext>(o => o.UseSqlServer(conn));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IPasswordHasher, PasswordHasher>();
        services.AddScoped<IJwtTokenService, JwtTokenService>();

        // Bring in Application layer services (AutoMapper, etc.)
        services.AddApplication();

        return services;
    }
}
