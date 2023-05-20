using AcoWeb.API.DbContexts;
using AcoWeb.API.Entities;

namespace AcoWeb.API.Services
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly EmployeesContext _context;

        public EmployeesRepository(EmployeesContext context)
        {
            _context = context;
        }

        public Employee GetEmployee(Guid employeeId, Guid officeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees(Guid officeId)
        {
            return _context.Employees.Where(x => x.OfficeId ==  officeId).ToList();          
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
