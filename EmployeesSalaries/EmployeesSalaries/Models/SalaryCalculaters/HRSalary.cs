using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class HRSalary : IEmployeeSalaryCalculater
    {
        public decimal BasicSalary { get; set; }

        public decimal GetNetSalary() { return BasicSalary; }
        public HRSalary(decimal salary)
        {
            BasicSalary = salary;
        }
    }
}
