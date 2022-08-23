using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class Manager : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Id { get; set; }
        public void AssignSuperVisor(IEmployee employeesSupervisor)
        {
            throw new Exception("Doesn't have a supervisor");
        }
    }
}
