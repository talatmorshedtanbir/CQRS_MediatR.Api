using CQRS_MediatR.Api.Helpers;
using CQRS_MediatR.Api.Models.Request.Filters;
using CQRS_MediatR.Api.Models.Response;
using MediatR;

namespace CQRS_MediatR.Api.Queries
{
    public record GetEmployeeListQuery(EmployeeFilterDto EmployeeFilterDto) : IRequest<PaginatedList<EmployeeResponseDto>>;
}
