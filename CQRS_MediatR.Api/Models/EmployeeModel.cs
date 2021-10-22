namespace CQRS_MediatR.Api.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public DateTime CreatedDate {  get; set; }
    }
}
