using AutoMapper;
using AutoMapper.QueryableExtensions;
using CQRS_MediatR.Api.DataAccessLayer.Abstract;
using CQRS_MediatR.Api.Extensions;
using CQRS_MediatR.Api.Helpers;
using CQRS_MediatR.Api.Models;
using CQRS_MediatR.Api.Models.Request;
using CQRS_MediatR.Api.Models.Request.Filters;
using CQRS_MediatR.Api.Models.Response;
using Microsoft.EntityFrameworkCore;

namespace CQRS_MediatR.Api.DataAccessLayer.Concrete
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private readonly IMapper _mapper;
        private List<Employee> _employees = new();

        public EmployeeDAL(IMapper mapper)
        {
            _mapper = mapper;

            _employees.Add(new Employee { Id = 1, Name = "Tanbir", CreatedDate = DateTime.Now, Salary = 1000});
            _employees.Add(new Employee { Id = 2, Name = "Talat", CreatedDate = DateTime.Now, Salary = 2000 });
        }

        public async Task<PaginatedList<EmployeeResponseDto>> GetAll(EmployeeFilterDto employeeFilterDto)
        {
            var employees = _employees.AsQueryable();

            if (string.IsNullOrEmpty(employeeFilterDto.SearchText) == false || string.IsNullOrWhiteSpace(employeeFilterDto.SearchText) == false)
            {
                employees = employees.Where(x => x.Name.ToUpper().Contains(employeeFilterDto.SearchText.ToUpper()));
            }

            var result = PaginatedList<EmployeeResponseDto>.ToPaginatedList(
                employees.ProjectTo<EmployeeResponseDto>(_mapper.ConfigurationProvider),
                employeeFilterDto.PageNumber,
                employeeFilterDto.PageSize);

            return result;
        }

        public async Task<EmployeeResponseDto> Get(int id)
        {
            var employees = _employees.AsQueryable();

            var employee = employees.Where(x => x.Id == id).FirstOrDefault();

            var result = _mapper.Map<EmployeeResponseDto>(employee);

            return result;
        }

        public async Task<int> Add(EmployeeModel employeeModel)
        {
            var newEmployee = _mapper.Map<Employee>(employeeModel);
            newEmployee.Id = _employees.Max(x => x.Id) + 1;
            _employees.Add(newEmployee);

            return newEmployee.Id;
        }
    }
}
