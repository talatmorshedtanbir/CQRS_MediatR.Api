using CQRS_MediatR.Api.DataAccessLayer.Abstract;
using CQRS_MediatR.Api.Models.ResponseDTOs;
using CQRS_MediatR.Api.Queries;
using MediatR;

namespace CQRS_MediatR.Api.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<EmployeeDTO>>
    {
        private readonly IEmployeeDAL _employeeDAL;
        public GetEmployeeListHandler(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }
        public Task<List<EmployeeDTO>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_employeeDAL.GetAll());
        }
    }
}
