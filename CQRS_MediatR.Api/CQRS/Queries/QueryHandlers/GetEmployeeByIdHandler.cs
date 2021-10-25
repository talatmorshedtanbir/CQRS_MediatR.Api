using CQRS_MediatR.Api.DataAccessLayer.Abstract;
using CQRS_MediatR.Api.Models.Response;
using MediatR;

namespace CQRS_MediatR.Api.CQRS.Queries.QueryHandlers
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeResponseDto>
    {
        private readonly IEmployeeDAL _employeeDAL;
        public GetEmployeeByIdHandler(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }
        public async Task<EmployeeResponseDto> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeDAL.Get(request.id);
        }
    }
}
