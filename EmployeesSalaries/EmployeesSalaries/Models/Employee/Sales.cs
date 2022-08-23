using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class Sales : IEmployee, IReportsTo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEmployee Supervisor { get; set; } = new Manager();

        public int Id { get; set; }
        public bool ReportsTo(int id) { return id == Id; }

        public void AssignSuperVisor(IEmployee employeesSupervisor)
        {
             Supervisor = employeesSupervisor;
        }
    }
}
