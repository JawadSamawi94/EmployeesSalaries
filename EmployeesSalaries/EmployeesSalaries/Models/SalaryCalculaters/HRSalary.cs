using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class HRSalary : IEmployeeSalaryCalculater
    {
        public double BasicSalary { get; set; } = 900;

        public double GetTotalSalary() { return BasicSalary; }
        public bool IsRequiredCalculater(string Role) { return Role == "HR"; }
    }
}
