using Kitchos.Domain.Interfaces;
using Kitchos.Infrastructure.Data;
using Kitchos.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Kitchos.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<AppDbContext>(options =>
            options.UseMySQL(connectionString!));

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
