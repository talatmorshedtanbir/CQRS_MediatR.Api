using CQRS_MediatR.Api.Models.Response;

namespace CQRS_MediatR.Api.Services.Abstract
{
    public interface IEmployeeService
    {
        public List<EmployeeResponseDto> GetAllEmployees();
        public EmployeeResponseDto GetEmployee(int id);
    }
}
