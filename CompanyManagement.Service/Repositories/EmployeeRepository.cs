using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyManagement.Contracts.Models;
using CompanyManagement.Contracts.Repositories;
using CompanyManagement.Service.Domain;
using CompanyManagement.Service.Infrastructure;

namespace CompanyManagement.Service.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly CompanyManagementDbContext _context;

        public EmployeeRepository(CompanyManagementDbContext context)
        {
            _context = context;
        }

        public async Task AddEmployee(EmployeeModel employee)
        {
            var employeeDataModel = new EmployeeDataModel()
            {
                FirstName = employee.FirstName,
                LastName = employee.FirstName
            };

            await _context.AddAsync(employeeDataModel);

            await _context.SaveChangesAsync();
        }

        public Task<List<EmployeeModel>> GetAllEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
