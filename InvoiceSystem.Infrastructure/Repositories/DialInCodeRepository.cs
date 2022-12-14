using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class DialInCodeRepository : NPRepository<DialInCode, short>, IDialInCodeRepository
{
    public DialInCodeRepository(PostgreSQLContext context) : base(context)
    {
    }
}
