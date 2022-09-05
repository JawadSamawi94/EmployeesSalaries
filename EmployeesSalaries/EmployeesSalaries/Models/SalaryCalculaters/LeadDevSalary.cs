using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class LeadDevSalary : IEmployeeSalaryCalculater
    {
        public decimal BasicSalary { get; set; }

        public decimal GetNetSalary() { return BasicSalary; }
        public LeadDevSalary(decimal salary)
        {
            BasicSalary = salary;
        }
    }
}
