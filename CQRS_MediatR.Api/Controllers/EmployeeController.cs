using CQRS_MediatR.Api.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using CQRS_MediatR.Api.Queries;
using CQRS_MediatR.Api.Models.Request.Filters;
using System.Text.Json;

namespace CQRS_MediatR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] EmployeeFilterDto employeeFilterDto)
        {
            try
            {
                var employees = await _mediator.Send(new GetEmployeeListQuery(employeeFilterDto));

                var metadata = new
                {
                    employees.PageSize,
                    employees.CurrentPage,
                    employees.PrevousPage,
                    employees.NextPage,
                    employees.TotalPages,
                    employees.ItemsCount
                };

                Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));

                return Ok(employees);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[HttpGet("getbyid")]
        //public IActionResult Get([FromQuery]int id)
        //{
        //    try
        //    {
        //        var employee = _employeeService.GetEmployee(id);

        //        return Ok(employee);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    }
}
