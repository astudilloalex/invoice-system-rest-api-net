using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class SupplierRepository : NPRepository<Supplier, int>, ISupplierRepository
{
    public SupplierRepository(PostgreSQLContext context) : base(context)
    {
    }
}
