using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class InvoiceRepository : NPRepository<Invoice, int>, IInvoiceRepository
{
    public InvoiceRepository(PostgreSQLContext context) : base(context)
    {
    }
}
