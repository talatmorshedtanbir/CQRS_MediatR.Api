using CQRS_MediatR.Api.Models.Response;
using MediatR;

namespace CQRS_MediatR.Api.CQRS.Queries
{
    public record GetEmployeeByIdQuery(int id) : IRequest<EmployeeResponseDto>;
}
