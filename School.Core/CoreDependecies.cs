using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace School.Core
{
    public static class CoreDependecies
    {
        public static IServiceCollection AddCoreDependecies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            return services;
        }
    }
}
