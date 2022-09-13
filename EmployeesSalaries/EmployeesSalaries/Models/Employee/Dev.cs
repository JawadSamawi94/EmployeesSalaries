using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class Dev : IEmployee, IReportsTo<LeadDev>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LeadDev Supervisor { get; set; } = new LeadDev();
        public IEmployeeSalaryCalculater SalaryCalc { get; set; }


        public void AssignSuperVisor(LeadDev employeesSupervisor)
        {
            Supervisor = employeesSupervisor;
        }
    }
}
