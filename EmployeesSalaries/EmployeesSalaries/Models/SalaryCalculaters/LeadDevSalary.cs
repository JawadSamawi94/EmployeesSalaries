using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class LeadDevSalary : IEmployeeSalaryCalculater
    {
        public double BasicSalary { get; set; } = 1100;

        public double GetNetSalary() { return BasicSalary; }
        public bool IsRequiredCalculater(string Role) { return Role == "LeadDev"; }
    }
}
