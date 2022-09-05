using EmployeesSalaries.Models;
using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Services
{
    public class EmployeeSalaryService : IEmployeeSalaryService
    {
        public decimal CalcSalary(IEmployee employee)
        {
            return employee.SalaryCalc.GetNetSalary();
        }
    }
}
