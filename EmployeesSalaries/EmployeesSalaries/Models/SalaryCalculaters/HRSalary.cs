using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class HRSalary : IEmployeeSalaryCalculater
    {
        public double BasicSalary { get; set; } = 900;

        public double GetNetSalary() { return BasicSalary; }
    }
}
