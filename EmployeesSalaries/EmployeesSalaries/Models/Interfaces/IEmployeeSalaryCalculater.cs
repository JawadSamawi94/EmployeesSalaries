namespace EmployeesSalaries.Models.Interfaces
{
    public interface IEmployeeSalaryCalculater
    {
        public decimal BasicSalary { get; set; }
        public decimal GetNetSalary();
    }
}
