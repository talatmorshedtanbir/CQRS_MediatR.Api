using CQRS_MediatR.Api.DataAccessLayer.Abstract;
using CQRS_MediatR.Api.DataAccessLayer.Concrete;
using CQRS_MediatR.Api.Services.Abstract;
using CQRS_MediatR.Api.Services.Concrete;
using MediatR;

namespace CQRS_MediatR.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureAppServices(this IServiceCollection services)
        {
            services.AddSwaggerGen();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddMediatR(typeof(IEmployeeDAL).Assembly);
        }

        public static void ConfigureDataAccess(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeDAL, EmployeeDAL>();
        }
    }
}
