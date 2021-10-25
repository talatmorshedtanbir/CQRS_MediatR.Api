using CQRS_MediatR.Api.Models;
using MediatR;

namespace CQRS_MediatR.Api.CQRS.Commands
{
    public record UpdateEmployeeCommand(Employee Employee) : IRequest;
}
