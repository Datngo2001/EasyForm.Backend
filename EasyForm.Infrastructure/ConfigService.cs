using EasyForm.Domain.Interfaces;
using EasyForm.Infrastructure.Database;
using EasyForm.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EasyForm.Infrastructure;

public static class ConfigService
{
    public static IServiceCollection ConfigInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("easyform");
            options.UseSqlServer(connectionString, sqlOptions => sqlOptions.MigrationsAssembly(typeof(DataContext).Assembly.FullName));
        });

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}