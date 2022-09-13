using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class HR : IEmployee, IReportsTo<Manager>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Manager Supervisor { get; set; } = new Manager();
        public IEmployeeSalaryCalculater SalaryCalc { get; set; }


        public void AssignSuperVisor(Manager employeesSupervisor)
        {
             Supervisor = employeesSupervisor;
        }
    }

}
