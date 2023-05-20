using AcoWeb.API.Entities;

namespace AcoWeb.API.Services
{
    public interface IEmployeesRepository
    {
        Employee GetEmployee(Guid employeeId, Guid officeId);
        IEnumerable<Employee> GetEmployees(Guid employeeId);

        IEnumerable<Employee> GetEmployees();
    }
}
