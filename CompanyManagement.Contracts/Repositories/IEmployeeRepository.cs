using CompanyManagement.Contracts.Models;

namespace CompanyManagement.Contracts.Repositories
{
    public interface IEmployeeRepository
    {
        Task AddEmployee(EmployeeModel employee);
        Task<List<EmployeeModel>> GetAllEmployees();
    }
}
