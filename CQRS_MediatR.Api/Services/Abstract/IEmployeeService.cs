using CQRS_MediatR.Api.Models.ResponseDTOs;

namespace CQRS_MediatR.Api.Services.Abstract
{
    public interface IEmployeeService
    {
        public List<EmployeeDTO> GetAllEmployees();
        public EmployeeDTO GetEmployee(int id);
    }
}
