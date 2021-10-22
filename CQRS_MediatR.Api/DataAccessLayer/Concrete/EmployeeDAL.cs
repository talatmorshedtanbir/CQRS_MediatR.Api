using AutoMapper;
using CQRS_MediatR.Api.DataAccessLayer.Abstract;
using CQRS_MediatR.Api.Models;
using CQRS_MediatR.Api.Models.ResponseDTOs;

namespace CQRS_MediatR.Api.DataAccessLayer.Concrete
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private readonly IMapper _mapper;
        private List<EmployeeModel> _employees = new();

        public EmployeeDAL(IMapper mapper)
        {
            _mapper = mapper;

            _employees.Add(new EmployeeModel { Id = 1, Name = "Tanbir", CreatedDate = DateTime.Now, Salary = 1000});
            _employees.Add(new EmployeeModel { Id = 2, Name = "Talat", CreatedDate = DateTime.Now, Salary = 2000 });
        }

        public List<EmployeeDTO> GetAll()
        {
            return _mapper.Map<List<EmployeeDTO>>(_employees);
        }
        public EmployeeDTO Get(int id)
        {
            var employee = _employees.Where(x => x.Id == id).FirstOrDefault();

            return _mapper.Map<EmployeeDTO>(employee);
        }
    }
}
