using Exploritas.Application.Services;
using Exploritas.Infrastructure.Mappers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Exploritas.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Exploritas.Infrastructure.Data.Repositories;
using Exploritas.Domain.Repositories;

namespace Exploritas.Infrastructure.IoC
{
    public static class ResolveDependencies
    {
        public static IServiceCollection Register(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<ICotaService, CotaService>();
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<ICotaRepository, CotaRepository>();
            services.AddDbContext<PortfolioContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("PortfolioConnection")));
            return services;
        }
    }
}
