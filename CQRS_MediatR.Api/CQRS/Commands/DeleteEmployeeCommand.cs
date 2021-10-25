using MediatR;

namespace CQRS_MediatR.Api.CQRS.Commands
{
    public record DeleteEmployeeCommand(int Id) : IRequest;
}
