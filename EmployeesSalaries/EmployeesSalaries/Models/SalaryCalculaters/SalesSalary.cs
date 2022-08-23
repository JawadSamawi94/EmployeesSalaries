using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class SalesSalary: IEmployeeSalaryCalculater
    {
        public double BasicSalary { get; set; } = 1000;
        public double Target { get; set; } = 1000;
        public double Sales { get; set; } = 1500;

        public double GetNetSalary() { return BasicSalary + (Target <= Sales ? Sales * 0.15 : 0); }
    }
}
