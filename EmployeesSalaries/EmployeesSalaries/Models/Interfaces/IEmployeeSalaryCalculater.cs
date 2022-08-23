namespace EmployeesSalaries.Models.Interfaces
{
    public interface IEmployeeSalaryCalculater
    {
        public double BasicSalary { get; set; }
        public double GetNetSalary();
        public bool IsRequiredCalculater(string Role);
    }
}
