using Hurghada.Service.Abstracts;
using Hurghada.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Hurghada.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IPropertyService, PropertyService>();
            services.AddTransient<IGuideService, GuideService>();
            return services;
        }
    }
}