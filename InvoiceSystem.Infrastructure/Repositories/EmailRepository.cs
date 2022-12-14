using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class EmailRepository : NPRepository<Email, int>, IEmailRepository
{
    public EmailRepository(PostgreSQLContext context) : base(context)
    {
    }
}
