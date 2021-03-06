using CQRS_MediatR.Api.Helpers;
using CQRS_MediatR.Api.Models;
using CQRS_MediatR.Api.Models.Request;
using CQRS_MediatR.Api.Models.Request.Filters;
using CQRS_MediatR.Api.Models.Response;

namespace CQRS_MediatR.Api.DataAccessLayer.Abstract
{
    public interface IEmployeeDAL
    {
        public Task<PaginatedList<EmployeeResponseDto>> GetAll(EmployeeFilterDto employeeFilterDto);
        public Task<EmployeeResponseDto> Get(int id);
        public Task<int> Add(EmployeeModel employeeModel);
        public Task Update(Employee employee);
        public Task Delete(int id);
    }
}
