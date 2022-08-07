namespace EmployeesSalaries.Models.Interfaces
{
    public interface IReportsTo
    {
        IEmployee Supervisor { get; }
        void Assign(IEmployee manager);
        bool ReportsTo(int id);
    }
}
