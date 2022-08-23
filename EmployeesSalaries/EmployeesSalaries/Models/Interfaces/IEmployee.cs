namespace EmployeesSalaries.Models.Interfaces
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Id { get; }
        IEmployeeSalaryCalculater SalaryCalc { get; }
        void AssignSuperVisor(IEmployee supervisor);
    }
}
