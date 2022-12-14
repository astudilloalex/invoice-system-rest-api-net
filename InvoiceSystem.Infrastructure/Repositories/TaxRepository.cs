using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class TaxRepository : NPRepository<Tax, short>, ITaxRepository
{
    public TaxRepository(PostgreSQLContext context) : base(context)
    {
    }
}
