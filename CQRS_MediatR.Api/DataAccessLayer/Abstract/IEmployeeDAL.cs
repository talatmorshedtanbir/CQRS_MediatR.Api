using CQRS_MediatR.Api.Models;
using CQRS_MediatR.Api.Models.ResponseDTOs;

namespace CQRS_MediatR.Api.DataAccessLayer.Abstract
{
    public interface IEmployeeDAL
    {
        public List<EmployeeDTO> GetAll();
        public EmployeeDTO Get(int id);
        //void AddEmployee(EmployeeModel employeeModel);
        //void DeleteEmployee(int id);
        //void UpdateEmployee(EmployeeModel employee);
    }
}
