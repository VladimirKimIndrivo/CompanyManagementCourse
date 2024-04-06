using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.API.Controllers
{
    [ApiController]
    [Route("api/companies")]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetCompanies()
        {
            return Empty;
        }

        [HttpPost]
        public ActionResult AddCompany()
        {   
            return Empty;
        }
    }
}
