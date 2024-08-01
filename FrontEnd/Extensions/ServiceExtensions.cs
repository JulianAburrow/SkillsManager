using DataAccess;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FrontEnd.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureSqlConnections(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("SkillsManager");
        services.AddDbContext<SkillsManagerContext>(
            options =>
                options.UseSqlServer(connectionString));
    }

    public static void AddDependencies(this IServiceCollection services)
    {
        services.AddTransient<ISkillData, SkillData>();
        services.AddTransient<IUserData, UserData>();
        services.AddTransient<IUserSkillData, UserSkillData>();
        services.AddTransient<IUserStatusData, UserStatusData>();
    }
}
