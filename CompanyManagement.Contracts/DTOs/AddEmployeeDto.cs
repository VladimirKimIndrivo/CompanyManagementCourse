using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Contracts.DTOs
{
    public class AddEmployeeDto
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
    }
}
