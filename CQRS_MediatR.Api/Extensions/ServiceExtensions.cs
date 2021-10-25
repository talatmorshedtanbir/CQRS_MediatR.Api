using CQRS_MediatR.Api.Behaviors;
using CQRS_MediatR.Api.DataAccessLayer.Abstract;
using CQRS_MediatR.Api.DataAccessLayer.Concrete;
using MediatR;

namespace CQRS_MediatR.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureAppServices(this IServiceCollection services)
        {
            services.AddSwaggerGen();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(typeof(IEmployeeDAL).Assembly);
            services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
        }

        public static void ConfigureDataAccess(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeDAL, EmployeeDAL>();
        }
    }
}
