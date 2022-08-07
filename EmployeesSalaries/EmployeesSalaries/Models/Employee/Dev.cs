using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class Dev : IEmployee, IReportsTo
    {
        public string FirstName { get; set; } = "Test";
        public string LastName { get; set; } = "Test";
        public IEmployee Supervisor { get; set; } = new LeadDev();

        public int Id { get; } = 4;
        public bool ReportsTo(int id) { return id >= Id; }

        public void Assign(IEmployee employeesSupervisor)
        {
            // this to check if the supervisor is the correct type (Dev reports to LeadDev)
            string employeeType = employeesSupervisor.GetType().Name;
            string supervisorType = Supervisor.GetType().Name;
            if (employeeType == supervisorType)
            {
                Supervisor = employeesSupervisor;
            }
            else
            {
                throw new BadHttpRequestException($"Dev Reports to LeadDev and not to {employeeType}");
            }
        }
    }
}
