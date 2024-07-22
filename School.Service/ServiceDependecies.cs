using Microsoft.Extensions.DependencyInjection;
using School.Service.Abstract;
using School.Service.Implemntation;

namespace School.Service
{
    public static class ServiceDependecies
    {
        public static IServiceCollection AddServiceDepencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }

    }
}
