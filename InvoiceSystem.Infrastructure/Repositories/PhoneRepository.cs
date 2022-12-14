using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class PhoneRepository : NPRepository<Phone, int>, IPhoneRepository
{
    public PhoneRepository(PostgreSQLContext context) : base(context)
    {
    }
}
