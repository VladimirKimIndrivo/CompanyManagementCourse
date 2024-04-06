using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.API.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("test")]
        public ActionResult GetEmployees()
        {   
            return Empty;
        }

        [HttpPost("addEmployee")]
        public ActionResult AddEmployee([FromBody] int x, [FromBody] int y)
        {           
            return Empty;
        }
    }
}
