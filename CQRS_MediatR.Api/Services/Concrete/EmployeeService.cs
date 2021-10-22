using CQRS_MediatR.Api.DataAccessLayer.Abstract;
using CQRS_MediatR.Api.Models.ResponseDTOs;
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

        public List<EmployeeDTO> GetAllEmployees()
        {
            return _employeeDAL.GetAll();
        }

        public EmployeeDTO GetEmployee(int id)
        {
            return _employeeDAL.Get(id);
        }
    }
}
