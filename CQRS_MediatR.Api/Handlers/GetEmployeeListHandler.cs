using CQRS_MediatR.Api.DataAccessLayer.Abstract;
using CQRS_MediatR.Api.Helpers;
using CQRS_MediatR.Api.Models.Response;
using CQRS_MediatR.Api.Queries;
using MediatR;

namespace CQRS_MediatR.Api.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, PaginatedList<EmployeeResponseDto>>
    {
        private readonly IEmployeeDAL _employeeDAL;
        public GetEmployeeListHandler(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }
        public async Task<PaginatedList<EmployeeResponseDto>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await _employeeDAL.GetAll(request.EmployeeFilterDto);
        }
    }
}
