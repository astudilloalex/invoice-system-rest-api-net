using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class PersonRepository : NPRepository<Person, int>, IPersonRepository
{
    public PersonRepository(PostgreSQLContext context) : base(context)
    {
    }
}
