using CQRS_MediatR.Api.DataAccessLayer.Abstract;
using MediatR;

namespace CQRS_MediatR.Api.CQRS.Commands.CommandHandlers
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, Unit>
    {
        private readonly IEmployeeDAL _employeeDAL;
        public UpdateEmployeeHandler(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public async Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            await _employeeDAL.Update(request.Employee);
            
            return Unit.Value;
        }
    }
}
