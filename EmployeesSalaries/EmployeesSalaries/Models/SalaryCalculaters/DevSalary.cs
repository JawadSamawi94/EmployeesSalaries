using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class DevSalary : IEmployeeSalaryCalculater
    {
        public decimal BasicSalary { get; set; }

        public decimal GetNetSalary() { return BasicSalary; }

        public DevSalary(decimal salary)
        {
            BasicSalary = salary;
        }
    }
}
