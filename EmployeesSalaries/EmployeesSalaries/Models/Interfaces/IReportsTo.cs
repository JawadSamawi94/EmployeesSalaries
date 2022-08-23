namespace EmployeesSalaries.Models.Interfaces
{
    public interface IReportsTo
    {
        IEmployee Supervisor { get; }
    }
}
