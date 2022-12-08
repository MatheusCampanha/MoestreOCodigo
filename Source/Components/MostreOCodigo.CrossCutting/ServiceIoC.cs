using Microsoft.Extensions.DependencyInjection;
using MostreOCodigo.Data.Context;
using MostreOCodigo.Data.Repository;
using MostreOCodigo.Domain.Repositories.Interfaces;
using MostreOCodigo.Domain.Repositories.Services;
using MostreOCodigo.Domain.Services;

namespace MostreOCodigo.CrossCutting
{
    public static class ServiceIoC
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<SkynetzContext>();
            services.AddScoped<IValorRepository, ValorRepository>();
            services.AddScoped<IValorServices, ValorServices>();

            return services;
        }
    }
}