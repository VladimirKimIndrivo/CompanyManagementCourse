namespace CompanyManagement.Service.Domain
{
    public class EmployeeDataModel : BaseDataModel<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;    
    }
}
