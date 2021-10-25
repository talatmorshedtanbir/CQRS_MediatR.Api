using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using CQRS_MediatR.Api.Models.Request.Filters;
using System.Text.Json;
using CQRS_MediatR.Api.CQRS.Queries;
using CQRS_MediatR.Api.Models.Request;
using CQRS_MediatR.Api.CQRS.Commands;

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

        [HttpGet("getbyid")]
        public IActionResult Get([FromQuery] int id)
        {
            try
            {
                var employee = _mediator.Send(new GetEmployeeByIdQuery(id));

                return Ok(employee.Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]EmployeeModel employeeModel)
        {
            try
            {
                var id = _mediator.Send(new CreateEmployeeCommand(employeeModel));

                return Ok(id.Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
