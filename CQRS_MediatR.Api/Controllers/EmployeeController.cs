using CQRS_MediatR.Api.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CQRS_MediatR.Api.Models.ResponseDTOs;
using MediatR;
using CQRS_MediatR.Api.Queries;

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
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _mediator.Send(new GetEmployeeListQuery());

                return Ok(result);
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
