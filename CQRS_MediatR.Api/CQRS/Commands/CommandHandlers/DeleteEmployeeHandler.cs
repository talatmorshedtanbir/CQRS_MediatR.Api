using CQRS_MediatR.Api.DataAccessLayer.Abstract;
using MediatR;

namespace CQRS_MediatR.Api.CQRS.Commands.CommandHandlers
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, Unit>
    {
        private readonly IEmployeeDAL _employeeDAL;
        public DeleteEmployeeHandler(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            await _employeeDAL.Delete(request.Id);

            return Unit.Value;
        }
    }
}
