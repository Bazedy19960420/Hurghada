using Hurghada.Infrastructure.Abstracts;
using Hurghada.Infrastructure.Abstracts.PropertyAbstract;
using Hurghada.Infrastructure.InfrastructureBase;
using Hurghada.Infrastructure.Repositories;
using Hurghada.Infrastructure.Repositories.PropertyRepository;
using Microsoft.Extensions.DependencyInjection;

namespace Hurghada.Infrastructure
{
    public static class ModuleInfrastructorDependencies
    {
        public static IServiceCollection AddInfrastructorDependencies(this IServiceCollection services)
        {
            services.AddTransient<IPropertyRepository, PropertyRepository>();
            services.AddTransient<IGuideRepository, GuideRepository>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}