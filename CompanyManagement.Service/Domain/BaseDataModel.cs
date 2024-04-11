namespace CompanyManagement.Service.Domain
{
    public class BaseDataModel<T> where T : struct
    {   
        public T Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset ModifiedAt { get; set; } = DateTimeOffset.Now; 
    }
}
