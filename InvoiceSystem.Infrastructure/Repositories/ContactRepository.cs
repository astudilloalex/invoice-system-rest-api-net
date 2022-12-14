using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class ContactRepository : NPRepository<Contact, int>, IContactRepository
{
    public ContactRepository(PostgreSQLContext context) : base(context)
    {
    }
}
