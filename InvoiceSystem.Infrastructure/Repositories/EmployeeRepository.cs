using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class EmployeeRepository : NPRepository<Employee, int>, IEmployeeRepository
{
    public EmployeeRepository(PostgreSQLContext context) : base(context)
    {
    }
}
