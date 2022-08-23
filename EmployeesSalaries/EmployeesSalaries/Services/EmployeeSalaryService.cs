using EmployeesSalaries.Models;
using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Services
{
    public class EmployeeSalaryService : IEmployeeSalaryService
    {
        public double CalcSalary(IEmployee employee)
        {
            return employee.SalaryCalc.GetNetSalary();
        }
    }
}
