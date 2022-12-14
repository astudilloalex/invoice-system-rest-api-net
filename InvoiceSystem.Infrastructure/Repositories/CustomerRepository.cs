using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class CustomerRepository : NPRepository<Customer, int>, ICustomerRepository
{
    public CustomerRepository(PostgreSQLContext context) : base(context)
    {
    }
}
