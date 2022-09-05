using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class ManagerSalary : IEmployeeSalaryCalculater
    {
        public decimal BasicSalary { get; set; }
        public decimal Bouns { get; set; }

        public decimal GetNetSalary() { return BasicSalary + Bouns; }
        public ManagerSalary(decimal salary, decimal bouns)
        {
            BasicSalary=salary;
            Bouns=bouns;
        }
    }
}
