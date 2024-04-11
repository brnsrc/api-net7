namespace primaira_api.Models
{
    public interface IEmployeeRepository
    {
        public void Add(Employee employee);
        List<Employee> Get();


    }
}
