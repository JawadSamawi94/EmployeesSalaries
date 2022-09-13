namespace EmployeesSalaries.Models.Interfaces
{
    public interface IReportsTo<T> where T : IEmployee
    {
        T Supervisor { get; }
        void AssignSuperVisor(T supervisor);
    }
}
