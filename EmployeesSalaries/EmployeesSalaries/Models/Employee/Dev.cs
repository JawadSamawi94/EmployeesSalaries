using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class Dev : IEmployee, IReportsTo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEmployee Supervisor { get; set; } = new LeadDev();
        public IEmployeeSalaryCalculater SalaryCalc { get; } = new DevSalary();


        public void AssignSuperVisor(IEmployee employeesSupervisor)
        {
            Supervisor = employeesSupervisor;
        }
    }
}
