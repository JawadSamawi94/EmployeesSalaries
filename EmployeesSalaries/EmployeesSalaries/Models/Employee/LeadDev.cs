﻿using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class LeadDev : IEmployee, IReportsTo
    {
        public string FirstName { get; set; } = "Test";
        public string LastName { get; set; } = "Test";
        public IEmployee Supervisor { get; set; } = new Manager();

        public int Id { get; } = 2;
        public bool ReportsTo(int id) { return id == Id; }

        public void Assign(IEmployee employeesSupervisor)
        {
             Supervisor = employeesSupervisor;
        }
    }
}
