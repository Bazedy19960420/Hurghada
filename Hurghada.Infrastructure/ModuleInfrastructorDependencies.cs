using Hurghada.Infrastructure.Abstracts.PropertyAbstract;
using Hurghada.Infrastructure.Repositories.PropertyRepository;
using Microsoft.Extensions.DependencyInjection;

namespace Hurghada.Infrastructure
{
    public static class ModuleInfrastructorDependencies
    {
        public static IServiceCollection AddInfrastructorDependencies(this IServiceCollection services)
        {
            services.AddTransient<IPropertyRepository, PropertyRepository>();
            return services;
        }
    }
}