using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class Manager : IEmployee
    {
        public string FirstName { get; set; } = "Test";
        public string LastName { get; set; } = "Test";

        public int Id { get; } = 0;

    }
}
