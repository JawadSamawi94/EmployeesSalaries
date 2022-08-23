using EmployeesSalaries.Models.Employee;
using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Services
{
    public class EmployeeService : IEmployeeService
    {
        private List<IEmployee> employees = new List<IEmployee>{
            new Manager{ FirstName="TestManager",LastName="TestManager"},
            new Sales{ FirstName="TestSales",LastName="TestSales"},
            new LeadDev{ FirstName="TestLeadDev",LastName="TestLeadDev"},
            new HR{ FirstName="TestHR",LastName="TestHR"},
            new Dev{ FirstName="TestDev",LastName="TestDev"}
        };
        private List<IReportsTo> employeesReportsTo = new List<IReportsTo>{
            new Sales{ FirstName="TestSales",LastName="TestSales"},
            new LeadDev{ FirstName="TestLeadDev",LastName="TestLeadDev"},
            new HR{ FirstName="TestHR",LastName="TestHR"},
            new Dev{ FirstName="TestDev",LastName="TestDev"}
        };
        public IEmployee GetEmployee(int id)
        {
            return employees.First(employee => employee.Id == id);
        }
        public List<IEmployee> GetEmployees()
        {
            return employees;
        }
        public IReportsTo GetEmployeeReportsTo(int employeeId)
        {
            return employeesReportsTo.First(emp => emp.ReportsTo(employeeId));
        }
    }
}

