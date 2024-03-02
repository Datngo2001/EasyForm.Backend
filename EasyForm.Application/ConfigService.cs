using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EasyForm.Application;

public static class ConfigService
{
    public static IServiceCollection ConfigApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ConfigService).Assembly));

        return services;
    }
}