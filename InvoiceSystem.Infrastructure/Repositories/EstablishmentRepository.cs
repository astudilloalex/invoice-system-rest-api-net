using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class EstablishmentRepository : NPRepository<Establishment, int>, IEstablishmentRepository
{
    public EstablishmentRepository(PostgreSQLContext context) : base(context)
    {
    }
}
