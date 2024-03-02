using EasyForm.Domain.Enums;
using EasyForm.Infrastructure.Database;
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
            options.UseSqlServer(connectionString);
        });

        return services;
    }
}