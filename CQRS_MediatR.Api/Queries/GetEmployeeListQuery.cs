using CQRS_MediatR.Api.Models.ResponseDTOs;
using MediatR;

namespace CQRS_MediatR.Api.Queries
{
    public record GetEmployeeListQuery : IRequest<List<EmployeeDTO>>;
}
