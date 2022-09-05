using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class SalesSalary: IEmployeeSalaryCalculater
    {
        public decimal BasicSalary { get; set; }
        public decimal Target { get; set; }
        public decimal Sales { get; set; }

        public decimal GetNetSalary() { return BasicSalary + (Target <= Sales ? ((Sales * 15) / 100) : 0); }
        public SalesSalary(decimal salary, decimal target, decimal sales)
        {
            BasicSalary = salary;
            Target = target;
            Sales = sales;
        }
    }
}
