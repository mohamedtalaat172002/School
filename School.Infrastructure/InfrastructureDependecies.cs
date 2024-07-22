using Microsoft.Extensions.DependencyInjection;
using School.Infrastructure.Abstract;
using School.Infrastructure.Implementaion;

namespace School.Infrastructure
{
    public static class InfrastructureDependecies
    {
        public static IServiceCollection AddInfrastructurreDependencies(this IServiceCollection services)
        {

            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IStudentRepo, StudentRepo>();
            return services;
        }
    }
}
