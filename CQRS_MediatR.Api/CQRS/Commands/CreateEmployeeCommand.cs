using CQRS_MediatR.Api.Models.Request;
using MediatR;

namespace CQRS_MediatR.Api.CQRS.Commands
{
    public record CreateEmployeeCommand(EmployeeModel EmployeeModel) : IRequest<int>;
}
