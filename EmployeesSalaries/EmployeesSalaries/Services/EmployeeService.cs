using EmployeesSalaries.Data;
using EmployeesSalaries.Models.Employee;
using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Services
{
    public class EmployeeService : IEmployeeService
    {
        private List<IEmployee> employees = EmployeeData.Employees;

        
        public IEmployee GetEmployee(int id)
        {
            return employees.First(employee => employee.Id == id);
        }


        public List<IEmployee> GetEmployees()
        {
            return employees;
        }

    }
}

