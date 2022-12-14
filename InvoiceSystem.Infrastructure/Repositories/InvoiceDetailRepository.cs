using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class InvoiceDetailRepository : NPRepository<InvoiceDetail, int>, IInvoiceDetailRepository
{
    public InvoiceDetailRepository(PostgreSQLContext context) : base(context)
    {
    }
}
