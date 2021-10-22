using AutoMapper;
using CQRS_MediatR.Api.Models;
using CQRS_MediatR.Api.Models.ResponseDTOs;

namespace CQRS_MediatR.Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<EmployeeModel, EmployeeDTO>()
                .ForMember(dest => dest.Name, o => o.MapFrom(src => src.Name))
                .ForMember(dest => dest.Salary, o => o.MapFrom(src => src.Salary))
                .ForMember(dest => dest.CreatedDate, o => o.MapFrom(src => src.CreatedDate))
                .ReverseMap();
        }
    }
}
