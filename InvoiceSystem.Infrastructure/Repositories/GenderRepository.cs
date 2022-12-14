using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class GenderRepository : NPRepository<Gender, short>, IGenderRepository
{
    public GenderRepository(PostgreSQLContext context) : base(context)
    {
    }
}
