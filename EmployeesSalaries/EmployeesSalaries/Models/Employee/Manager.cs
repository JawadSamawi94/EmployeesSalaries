using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class Manager : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Id { get; set; }

    }
}
