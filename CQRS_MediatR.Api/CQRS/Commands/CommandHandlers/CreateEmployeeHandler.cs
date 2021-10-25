using CQRS_MediatR.Api.DataAccessLayer.Abstract;
using MediatR;

namespace CQRS_MediatR.Api.CQRS.Commands.CommandHandlers
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly IEmployeeDAL _employeeDAL;
        public CreateEmployeeHandler(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var id = _employeeDAL.Add(request.EmployeeModel);

            return id.Result;
        }
    }
}
