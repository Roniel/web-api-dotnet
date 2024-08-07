using AppWebApiEstudo.Application.Mappings;
using AppWebApiEstudo.Application.Services;
using AppWebApiEstudo.Application.Services.Interfaces;
using AppWebApiEstudo.Domain.Interfaces;
using AppWebApiEstudo.Infra.Data.Context;
using AppWebApiEstudo.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppWebApiEstudo.Infra.IoC
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
            string configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration
            , b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IBeneficiarioRepository, BeneficiarioRepository>();

            services.AddScoped<IBeneficiarioService, BeneficiarioService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}
