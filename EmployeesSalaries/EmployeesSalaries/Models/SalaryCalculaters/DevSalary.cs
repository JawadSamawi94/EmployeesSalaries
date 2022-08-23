using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class DevSalary : IEmployeeSalaryCalculater
    {
        public double BasicSalary { get; set; } = 800;

        public double GetNetSalary() { return BasicSalary; }
        public bool IsRequiredCalculater(string Role) { return Role == "Dev"; }
    }
}
