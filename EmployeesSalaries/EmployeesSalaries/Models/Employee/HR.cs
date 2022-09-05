﻿using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class HR : IEmployee, IReportsTo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEmployee Supervisor { get; set; } = new Manager();
        public IEmployeeSalaryCalculater SalaryCalc { get; set; }


        public void AssignSuperVisor(IEmployee employeesSupervisor)
        {
             Supervisor = employeesSupervisor;
        }
    }

}
