using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class Manager : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEmployeeSalaryCalculater SalaryCalc { get; } = new ManagerSalary();

        public void AssignSuperVisor(IEmployee employeesSupervisor)
        {
            throw new Exception("Doesn't have a supervisor");
        }
    }
}
