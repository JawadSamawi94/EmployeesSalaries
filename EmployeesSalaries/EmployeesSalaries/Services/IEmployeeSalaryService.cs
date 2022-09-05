using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Services
{
    public interface IEmployeeSalaryService
    {
        public decimal CalcSalary(IEmployee employee);
    }
}
