namespace CQRS_MediatR.Api.Models.Request
{
    public class EmployeeModel
    {
        public string Name { get; set; }
        public int Salary {  get; set; }
        public string CreatedDate
        {
            get
            {
                return DateTime.Now.ToString();
            }
        }
    }
}
