using CQRS_MediatR.Api.DataAccessLayer.Abstract;
using CQRS_MediatR.Api.Models.Response;
using CQRS_MediatR.Api.Services.Abstract;

namespace CQRS_MediatR.Api.Services.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeDAL _employeeDAL;
        public EmployeeService(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public List<EmployeeResponseDto> GetAllEmployees()
        {
            return new List<EmployeeResponseDto>();
        }

        public EmployeeResponseDto GetEmployee(int id)
        {
            return new EmployeeResponseDto();
        }
    }
}
