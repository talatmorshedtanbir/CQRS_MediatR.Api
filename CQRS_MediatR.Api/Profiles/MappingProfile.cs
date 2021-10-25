using AutoMapper;
using CQRS_MediatR.Api.Models;
using CQRS_MediatR.Api.Models.Request;
using CQRS_MediatR.Api.Models.Response;

namespace CQRS_MediatR.Api.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Employee, EmployeeResponseDto>();
            CreateMap<EmployeeModel, Employee>();
        }
    }
}
