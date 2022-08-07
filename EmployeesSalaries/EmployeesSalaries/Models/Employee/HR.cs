using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class HR : IEmployee, IReportsTo
    {
        public string FirstName { get; set; } = "Test";
        public string LastName { get; set; } = "Test";
        public IEmployee Supervisor { get; } = new Manager();

        public int Id { get; } = 3;

        public bool ReportsTo(int id) { return id == Id; }
        public void Assign(IEmployee employeesSupervisor)
        {
            // this to check if the supervisor is the correct type (HR reports to Manager)
            string employeeType = employeesSupervisor.GetType().Name;
            string supervisorType = Supervisor.GetType().Name;
            if (employeeType == supervisorType)
            {
                Supervisor = employeesSupervisor;
            }
            else
            {
                throw new BadHttpRequestException($"HR Reports to Manager and not to {employeeType}");
            }
        }
    }

}
