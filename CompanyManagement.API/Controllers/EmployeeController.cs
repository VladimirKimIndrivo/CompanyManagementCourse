using CompanyManagement.Contracts.Models;
using CompanyManagement.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.API.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("")]
        public ActionResult GetEmployees()
        {   
            return Empty;
        }

        [HttpPost("")]
        public async Task<ActionResult> AddEmployee([FromBody] EmployeeModel emplyee)
        {                       
            await _repository.AddEmployee(emplyee);

            return Ok();
        }
    }
}
